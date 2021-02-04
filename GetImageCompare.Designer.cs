
namespace HistogramOCRTrainer
{
    partial class GetImageCompare
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
            this.imagepanel = new System.Windows.Forms.Panel();
            this.textbox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.okbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagepanel
            // 
            this.imagepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagepanel.Location = new System.Drawing.Point(213, 0);
            this.imagepanel.Name = "imagepanel";
            this.imagepanel.Size = new System.Drawing.Size(337, 164);
            this.imagepanel.TabIndex = 11;
            // 
            // textbox
            // 
            this.textbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.textbox.Location = new System.Drawing.Point(0, 0);
            this.textbox.Multiline = true;
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(208, 58);
            this.textbox.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(3, 10);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(24, 17);
            this.label.TabIndex = 3;
            this.label.Text = "    ";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Silver;
            this.splitter1.Location = new System.Drawing.Point(208, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 164);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textbox);
            this.panel1.Controls.Add(this.label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 164);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.okbutton);
            this.panel2.Controls.Add(this.cancelbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 100);
            this.panel2.TabIndex = 6;
            // 
            // okbutton
            // 
            this.okbutton.BackColor = System.Drawing.Color.White;
            this.okbutton.BackgroundImage = global::NPCIlin.Properties.Resources.Next_arrow_1559;
            this.okbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.okbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okbutton.Location = new System.Drawing.Point(0, 0);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(133, 100);
            this.okbutton.TabIndex = 4;
            this.okbutton.UseVisualStyleBackColor = false;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cancelbutton.BackgroundImage = global::NPCIlin.Properties.Resources.cancel_icon_icons_com_52401;
            this.cancelbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelbutton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelbutton.Location = new System.Drawing.Point(133, 0);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 100);
            this.cancelbutton.TabIndex = 5;
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // GetImageCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 164);
            this.Controls.Add(this.imagepanel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GetImageCompare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetImageCompare";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel imagepanel;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}