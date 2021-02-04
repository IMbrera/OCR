using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistogramOCRTrainer
{
    public partial class GetImageCompare : Form
    {
        private string[] returnvalue;
        public GetImageCompare()
        {
            InitializeComponent();
        }
        public string[] ShowDialog(string labelText, string title, Image img, int maxlen = -1,
          ImageLayout il = ImageLayout.Center)
        {
            Text = title;
            label.Text = labelText;
            imagepanel.BackgroundImage = img;
            imagepanel.BackgroundImageLayout = il;

            if (maxlen >= 0)
                textbox.MaxLength = maxlen;

            ShowDialog();
            return returnvalue;
        }
        private void OK()
        {
            returnvalue = textbox.Text.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            Close();
        }
        private void okbutton_Click(object sender, EventArgs e)
        {
            OK();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
