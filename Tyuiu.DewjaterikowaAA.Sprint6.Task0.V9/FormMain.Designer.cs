namespace Tyuiu.DewjaterikowaAA.Sprint6.Task0.V9
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxCondition_DAA = new GroupBox();
            textBoxCondition_DAA = new TextBox();
            groupBoxInput_DAA = new GroupBox();
            textBoxVarX_DAA = new TextBox();
            labelVarX_DAA = new TextBox();
            groupBoxOutput_DAA = new GroupBox();
            textBoxResult_DAA = new TextBox();
            labelResult_DAA = new TextBox();
            buttonResult_DAA = new Button();
            buttonHelp_DAA = new Button();
            pictureBox_DAA = new PictureBox();
            groupBoxCondition_DAA.SuspendLayout();
            groupBoxInput_DAA.SuspendLayout();
            groupBoxOutput_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DAA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_DAA
            // 
            groupBoxCondition_DAA.Controls.Add(textBoxCondition_DAA);
            groupBoxCondition_DAA.Location = new Point(26, 21);
            groupBoxCondition_DAA.Name = "groupBoxCondition_DAA";
            groupBoxCondition_DAA.Size = new Size(356, 254);
            groupBoxCondition_DAA.TabIndex = 0;
            groupBoxCondition_DAA.TabStop = false;
            groupBoxCondition_DAA.Text = "Условие";
            // 
            // textBoxCondition_DAA
            // 
            textBoxCondition_DAA.Location = new Point(16, 39);
            textBoxCondition_DAA.Multiline = true;
            textBoxCondition_DAA.Name = "textBoxCondition_DAA";
            textBoxCondition_DAA.ReadOnly = true;
            textBoxCondition_DAA.Size = new Size(298, 37);
            textBoxCondition_DAA.TabIndex = 0;
            textBoxCondition_DAA.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInput_DAA
            // 
            groupBoxInput_DAA.Controls.Add(textBoxVarX_DAA);
            groupBoxInput_DAA.Controls.Add(labelVarX_DAA);
            groupBoxInput_DAA.Location = new Point(26, 292);
            groupBoxInput_DAA.Name = "groupBoxInput_DAA";
            groupBoxInput_DAA.Size = new Size(356, 121);
            groupBoxInput_DAA.TabIndex = 1;
            groupBoxInput_DAA.TabStop = false;
            groupBoxInput_DAA.Text = "Ввод данных";
            // 
            // textBoxVarX_DAA
            // 
            textBoxVarX_DAA.Location = new Point(16, 69);
            textBoxVarX_DAA.Name = "textBoxVarX_DAA";
            textBoxVarX_DAA.Size = new Size(125, 27);
            textBoxVarX_DAA.TabIndex = 1;
            textBoxVarX_DAA.KeyPress += textBoxVarX_DAA_KeyPress;
            // 
            // labelVarX_DAA
            // 
            labelVarX_DAA.BackColor = SystemColors.MenuBar;
            labelVarX_DAA.Location = new Point(16, 26);
            labelVarX_DAA.Name = "labelVarX_DAA";
            labelVarX_DAA.Size = new Size(125, 27);
            labelVarX_DAA.TabIndex = 0;
            labelVarX_DAA.Text = "Переменная X";
            // 
            // groupBoxOutput_DAA
            // 
            groupBoxOutput_DAA.Controls.Add(textBoxResult_DAA);
            groupBoxOutput_DAA.Controls.Add(labelResult_DAA);
            groupBoxOutput_DAA.Location = new Point(442, 292);
            groupBoxOutput_DAA.Name = "groupBoxOutput_DAA";
            groupBoxOutput_DAA.Size = new Size(312, 104);
            groupBoxOutput_DAA.TabIndex = 2;
            groupBoxOutput_DAA.TabStop = false;
            groupBoxOutput_DAA.Text = "Вывод данных";
            // 
            // textBoxResult_DAA
            // 
            textBoxResult_DAA.Location = new Point(16, 69);
            textBoxResult_DAA.Name = "textBoxResult_DAA";
            textBoxResult_DAA.ReadOnly = true;
            textBoxResult_DAA.Size = new Size(125, 27);
            textBoxResult_DAA.TabIndex = 1;
            // 
            // labelResult_DAA
            // 
            labelResult_DAA.BackColor = SystemColors.MenuBar;
            labelResult_DAA.Location = new Point(16, 26);
            labelResult_DAA.Name = "labelResult_DAA";
            labelResult_DAA.Size = new Size(125, 27);
            labelResult_DAA.TabIndex = 0;
            labelResult_DAA.Text = "Результат";
            // 
            // buttonResult_DAA
            // 
            buttonResult_DAA.Location = new Point(599, 409);
            buttonResult_DAA.Name = "buttonResult_DAA";
            buttonResult_DAA.Size = new Size(155, 29);
            buttonResult_DAA.TabIndex = 3;
            buttonResult_DAA.Text = "Выполнить";
            buttonResult_DAA.UseVisualStyleBackColor = true;
            buttonResult_DAA.Click += buttonResult_DAA_Click;
            // 
            // buttonHelp_DAA
            // 
            buttonHelp_DAA.BackColor = SystemColors.ButtonHighlight;
            buttonHelp_DAA.Location = new Point(547, 409);
            buttonHelp_DAA.Name = "buttonHelp_DAA";
            buttonHelp_DAA.Size = new Size(36, 29);
            buttonHelp_DAA.TabIndex = 4;
            buttonHelp_DAA.Text = "?";
            buttonHelp_DAA.UseVisualStyleBackColor = false;
            buttonHelp_DAA.Click += buttonHelp_DAA_Click;
            // 
            // pictureBox_DAA
            // 
            pictureBox_DAA.Image = Properties.Resources.Screenshot_2025_12_05_at_19_05_41_Сдача_задания;
            pictureBox_DAA.Location = new Point(587, 75);
            pictureBox_DAA.Name = "pictureBox_DAA";
            pictureBox_DAA.Size = new Size(134, 82);
            pictureBox_DAA.TabIndex = 5;
            pictureBox_DAA.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox_DAA);
            Controls.Add(buttonHelp_DAA);
            Controls.Add(buttonResult_DAA);
            Controls.Add(groupBoxOutput_DAA);
            Controls.Add(groupBoxInput_DAA);
            Controls.Add(groupBoxCondition_DAA);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 9 | Девятерикова А.А.";
            groupBoxCondition_DAA.ResumeLayout(false);
            groupBoxCondition_DAA.PerformLayout();
            groupBoxInput_DAA.ResumeLayout(false);
            groupBoxInput_DAA.PerformLayout();
            groupBoxOutput_DAA.ResumeLayout(false);
            groupBoxOutput_DAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_DAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_DAA;
        private TextBox textBoxCondition_DAA;
        private GroupBox groupBoxInput_DAA;
        private TextBox textBoxVarX_DAA;
        private TextBox labelVarX_DAA;
        private GroupBox groupBoxOutput_DAA;
        private TextBox textBoxResult_DAA;
        private TextBox labelResult_DAA;
        private Button buttonResult_DAA;
        private Button buttonHelp_DAA;
        private PictureBox pictureBox_DAA;
    }
}
