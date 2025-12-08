namespace Tyuiu.DewjaterikowaAA.Sprint6.Task6.V18
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox_DAA = new PictureBox();
            textBoxInfo_DAA = new TextBox();
            buttonOK_DAA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DAA).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_DAA
            // 
            pictureBox_DAA.Image = (Image)resources.GetObject("pictureBox_DAA.Image");
            pictureBox_DAA.Location = new Point(12, 14);
            pictureBox_DAA.Name = "pictureBox_DAA";
            pictureBox_DAA.Size = new Size(184, 227);
            pictureBox_DAA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_DAA.TabIndex = 0;
            pictureBox_DAA.TabStop = false;
            // 
            // textBoxInfo_DAA
            // 
            textBoxInfo_DAA.Location = new Point(205, 14);
            textBoxInfo_DAA.Multiline = true;
            textBoxInfo_DAA.Name = "textBoxInfo_DAA";
            textBoxInfo_DAA.Size = new Size(400, 190);
            textBoxInfo_DAA.TabIndex = 1;
            textBoxInfo_DAA.Text = "Разработчик: Девятерикова А.А.\r\nГруппа ИИПБ-25-1\r\nПрограмма разработана в рамках изучения языка С#\r\n\r\nТИУ(с) 2025\r\nВШЦТ(с) 2025\r\n\r\nВнутреннее имя: Tyuiu.DewjaterikowaAA.Sprint6.Task6.V18\r\n\r\n\r\n\r\n";
            // 
            // buttonOK_DAA
            // 
            buttonOK_DAA.Location = new Point(511, 210);
            buttonOK_DAA.Name = "buttonOK_DAA";
            buttonOK_DAA.Size = new Size(94, 29);
            buttonOK_DAA.TabIndex = 2;
            buttonOK_DAA.Text = "Ok";
            buttonOK_DAA.UseVisualStyleBackColor = true;
            buttonOK_DAA.Click += this.buttonOK_DAA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 244);
            Controls.Add(buttonOK_DAA);
            Controls.Add(textBoxInfo_DAA);
            Controls.Add(pictureBox_DAA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О пользователе";
            ((System.ComponentModel.ISupportInitialize)pictureBox_DAA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_DAA;
        private TextBox textBoxInfo_DAA;
        private Button buttonOK_DAA;
    }
}