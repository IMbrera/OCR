using HistogramOCRTrainer.FEctra;
using NPCIlin.Properties;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace HistogramOCRTrainer
{
    public partial class MainForm : Form
    {
        public static SymbolIdentity symbol;
      
        public MainForm()
        {
           
            InitializeComponent();
          
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void offFunc()
        {
            delSymbol.Enabled = false;
            loadText.Enabled = false;
            this.tabControl1.Enabled = false;
        }
        private void onFunc()
        {
            delSymbol.Enabled = true;
            loadText.Enabled = true;
            this.tabControl1.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            symbol = new SymbolIdentity();
            RefreshLettersList();
            offFunc();
         
            
        }

        private void RefreshLettersList()
        {
            lettersLB.Items.Clear();
            letterhistogramdisplayTB.Text = "";

            symbol.Letters = symbol.Letters.OrderBy(s => s.Letter).ToList();
            foreach (var l in symbol.Letters)
            {
                lettersLB.Items.Add(l.Letter);
               
            }
        }

        private void lettersLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            letterhistogramdisplayTB.Text = "";
            var sel = lettersLB.SelectedIndex;
            if (sel == -1)
                return;
            // список символов словаря!
            var letter = ((char)lettersLB.Items[sel]);
            // гистограмма символа!
            SetHistogramDisplay(symbol.Letters.FirstOrDefault(s => s.Letter.Equals(letter)));
            MessageBox.Show(Settings.Default.dictionary.ToString());

        }

        private void SetHistogramDisplay(SymbolIdentity.HistogramLetter hl)
        {
            if (hl == null)
                return;

            //merge arrays
            int[][] a = ArrayExtras.InstantiateArray<int>(symbol.HistogramWidth, symbol.HistogramHeight);
            int yc = hl.YValues.Count();
            int xc = hl.XValues.Count();
            for (int y = 0; y < yc; y++)
            {
                for (int v = 0; v < hl.YValues[y]; v++)
                {
                    if (y >= symbol.HistogramHeight || v >= symbol.HistogramWidth)
                        continue;
                    a[y][v] += 10;
                }
            }

            for (int x = 0; x < xc; x++)
            {
                var ymax = yc - 1;
                var ymin = ymax - hl.XValues[x];
                for (int v = ymax; v > ymin; v--)
                {
                    if (v >= symbol.HistogramHeight || x >= symbol.HistogramWidth)
                        continue;
                    a[v][x] += 100;
                }
            }

         
            for (int y = 0; y < yc; y++)
            {
                for (int x = 0; x < xc; x++)
                {
                    if (y >= symbol.HistogramHeight || x >= symbol.HistogramWidth)
                        continue;

                    var v1 = a[y][x];
                    var c = '1';
                    if (v1 == 10)
                        c = '4';
                    else if (v1 == 100)
                        c = '6';
                    else if (v1 == 110)
                        c = '8';

                    letterhistogramdisplayTB.Text += c;
                    Settings.Default.dictionary += c;
                    
                }
                letterhistogramdisplayTB.Text += Environment.NewLine;
            
            }
        }
 
        private void SaveHist()
        {
            var sfd = new SaveFileDialog();
            sfd.Title = "Cохранение словаря";
            sfd.Filter = "Словарь (*.ilin)|";
            sfd.InitialDirectory = Directory.GetCurrentDirectory();
            var res = sfd.ShowDialog();
            if (res != DialogResult.OK)
                return;
            var fn = sfd.FileName;
            symbol.Serialise(fn);
        }
        private void TestLoadBitmap(Bitmap b)
        {   
            var images = symbol.SplitUp(b); // пробелы между символами
            //load white space straight away
            if (symbol.Letters.Any(s => s.Letter.Equals(' ')) == false)
                symbol.Train(SymbolIdentity.WhiteBitmap, ' ');
            //for each image that hasnt been seen, have the player enter it
            foreach (var row in images)
            {
                foreach (var col in row)
                {
                    //try and find a perfect match
                    var c = symbol.PerformOCRCharacterPerfect(col);
                    //we only want things we havent seen before
                    if (c != null)
                        continue;

                    if (BitmapExtras.IsAllPixelsAColour(col, Color.White))
                    {
                        continue;
                    }

                    //ask user for character and show
                    var gsi = new GetImageCompare();
                    var letters = gsi.ShowDialog("Какой символ изображен на форме?", "Определение символов", col,1);
                    if (letters == null)
                        return;

                    if (letters.Length == 0)
                    {
                        continue;

                    }
                    var letter = letters.First().First();
                    if (char.IsWhiteSpace(letter))
                    {
                        MessageBox.Show("cannot be white space");
                        return;
                    }

                    if (symbol.Letters.Any(s => s.Letter.Equals(letter)))
                    {
                        symbol.Letters.RemoveAll(s => s.Letter.Equals(letter));
                    }

                    //ОБУЧЕНИЕ
                    symbol.Train(col, letter);
                }
            }
        }

        private void загрузитьСловарьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var ofd = new OpenFileDialog();
            ofd.Title = "Загрузка словаря";
            ofd.Filter = "Словарь (*.ilin)|";
            ofd.Multiselect = false;
            ofd.InitialDirectory = "C:\\Users\\milins\\Desktop\\II\\fonts";
            var res = ofd.ShowDialog();
            if (res != DialogResult.OK)
                return;

            var fn = ofd.FileName;
            symbol = SymbolIdentity.DeSerialise(fn);    
            RefreshLettersList();      
            onFunc();
 
        }

        private void удалитьСимволToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lettersLB.SelectedItems.Count == 0)
                    return;

                foreach (var i in lettersLB.SelectedItems)
                {
                    var ch = i.ToString()[0];
                    //   h.RemoveByLetter(ch);
                }
                // ListBoxExtras.RemoveSelected(ref lettersLB);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления символа:" + ex);
            }
        }

        private void создатьСловарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //get image
            var ofd = new OpenFileDialog();
            ofd.Title = "Выберите изображение с символами для создания словаря";
            ofd.Multiselect = false;
            ofd.InitialDirectory = Directory.GetCurrentDirectory();
            var res = ofd.ShowDialog();
            if (res != DialogResult.OK)          
                return;
                var fn = ofd.FileName;
            Bitmap b;
            try
            {
                b = new Bitmap(fn);
                onFunc();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex.ToString());
                return;
            }

            TestLoadBitmap(b);
            RefreshLettersList();

            res = MessageBox.Show("Сохранить словарь?", "Буквы успешно определены", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                SaveHist();
            }
         
        }

        private void загрузитьТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap img;
            var ofd = new OpenFileDialog();
            ofd.Title = "Загрузка изображения для распознавания";
            ofd.Multiselect = false;
            ofd.InitialDirectory = Directory.GetCurrentDirectory();
            var res = ofd.ShowDialog();
            if (res != DialogResult.OK)
                return;

            var fn = ofd.FileName;

            try
            {
                img = new Bitmap(ofd.FileName);
                this.pictureBox1.Size = img.Size;
                pictureBox1.Image = img;
                testTextBox.Text = "";
                var wf = symbol.PerformOCR(fn, 50);
                foreach (var row in wf)
                {
                    testTextBox.Text += row + "\r\n";
                }
                this.WindowState = FormWindowState.Maximized;
                nameImage.Text = ofd.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
           
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
