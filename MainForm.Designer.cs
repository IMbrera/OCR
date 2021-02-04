namespace HistogramOCRTrainer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьСловарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьСловарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delSymbol = new System.Windows.Forms.ToolStripMenuItem();
            this.loadText = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.nameImage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.letterhistogramdisplayTB = new System.Windows.Forms.TextBox();
            this.lettersLB = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.testTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Orange;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.действияToolStripMenuItem,
            this.delSymbol,
            this.loadText,
            this.testToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.desToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьСловарьToolStripMenuItem,
            this.загрузитьСловарьToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.действияToolStripMenuItem.Text = "Словарь";
            // 
            // создатьСловарьToolStripMenuItem
            // 
            this.создатьСловарьToolStripMenuItem.Name = "создатьСловарьToolStripMenuItem";
            this.создатьСловарьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.создатьСловарьToolStripMenuItem.Text = "Создать словарь";
            this.создатьСловарьToolStripMenuItem.Click += new System.EventHandler(this.создатьСловарьToolStripMenuItem_Click);
            // 
            // загрузитьСловарьToolStripMenuItem
            // 
            this.загрузитьСловарьToolStripMenuItem.Name = "загрузитьСловарьToolStripMenuItem";
            this.загрузитьСловарьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.загрузитьСловарьToolStripMenuItem.Text = "Загрузить словарь";
            this.загрузитьСловарьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьСловарьToolStripMenuItem_Click);
            // 
            // delSymbol
            // 
            this.delSymbol.Name = "delSymbol";
            this.delSymbol.Size = new System.Drawing.Size(135, 24);
            this.delSymbol.Text = "Удалить символ";
            this.delSymbol.Click += new System.EventHandler(this.удалитьСимволToolStripMenuItem_Click);
            // 
            // loadText
            // 
            this.loadText.Name = "loadText";
            this.loadText.Size = new System.Drawing.Size(129, 24);
            this.loadText.Text = "Загрузить текст";
            this.loadText.Click += new System.EventHandler(this.загрузитьТекстToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // desToolStripMenuItem
            // 
            this.desToolStripMenuItem.Name = "desToolStripMenuItem";
            this.desToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameImage,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 618);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(792, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // nameImage
            // 
            this.nameImage.Name = "nameImage";
            this.nameImage.Size = new System.Drawing.Size(0, 20);
            this.nameImage.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 590);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.letterhistogramdisplayTB);
            this.tabPage1.Controls.Add(this.lettersLB);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.ForeColor = System.Drawing.Color.DarkRed;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(784, 561);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Обучение";
            // 
            // letterhistogramdisplayTB
            // 
            this.letterhistogramdisplayTB.Dock = System.Windows.Forms.DockStyle.Right;
            this.letterhistogramdisplayTB.Location = new System.Drawing.Point(174, 4);
            this.letterhistogramdisplayTB.Margin = new System.Windows.Forms.Padding(4);
            this.letterhistogramdisplayTB.Multiline = true;
            this.letterhistogramdisplayTB.Name = "letterhistogramdisplayTB";
            this.letterhistogramdisplayTB.Size = new System.Drawing.Size(606, 553);
            this.letterhistogramdisplayTB.TabIndex = 1;
            this.letterhistogramdisplayTB.Text = "Гистограмма";
            // 
            // lettersLB
            // 
            this.lettersLB.Dock = System.Windows.Forms.DockStyle.Left;
            this.lettersLB.FormattingEnabled = true;
            this.lettersLB.ItemHeight = 23;
            this.lettersLB.Items.AddRange(new object[] {
            "Символы словаря"});
            this.lettersLB.Location = new System.Drawing.Point(4, 4);
            this.lettersLB.Margin = new System.Windows.Forms.Padding(4);
            this.lettersLB.Name = "lettersLB";
            this.lettersLB.Size = new System.Drawing.Size(162, 553);
            this.lettersLB.TabIndex = 0;
            this.lettersLB.SelectedIndexChanged += new System.EventHandler(this.lettersLB_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.testTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(784, 561);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Тестирование";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 553);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // testTextBox
            // 
            this.testTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.testTextBox.Location = new System.Drawing.Point(191, 4);
            this.testTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.testTextBox.Multiline = true;
            this.testTextBox.Name = "testTextBox";
            this.testTextBox.Size = new System.Drawing.Size(589, 553);
            this.testTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 644);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(810, 691);
            this.Name = "MainForm";
            this.Text = "Нейрокомпьютеры и сети. Ильин М.С.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox letterhistogramdisplayTB;
        private System.Windows.Forms.ListBox lettersLB;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьСловарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьСловарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delSymbol;
        private System.Windows.Forms.ToolStripMenuItem loadText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox testTextBox;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel nameImage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

