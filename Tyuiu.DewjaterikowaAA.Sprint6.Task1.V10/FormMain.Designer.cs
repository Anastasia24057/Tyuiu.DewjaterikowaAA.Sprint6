namespace Tyuiu.DewjaterikowaAA.Sprint6.Task1.V10
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
            textBoxStop_DAA = new TextBox();
            labelStop_DAA = new TextBox();
            textBoxStart_DAA = new TextBox();
            labelStart_DAA = new TextBox();
            buttonHelp_DAA = new Button();
            buttonResult_DAA = new Button();
            groupBoxResult_DAA = new GroupBox();
            textBoxResult_DAA = new TextBox();
            labelResult_DAA = new TextBox();
            groupBoxCondition_DAA.SuspendLayout();
            groupBoxInput_DAA.SuspendLayout();
            groupBoxResult_DAA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_DAA
            // 
            groupBoxCondition_DAA.Controls.Add(textBoxCondition_DAA);
            groupBoxCondition_DAA.Location = new Point(24, 24);
            groupBoxCondition_DAA.Name = "groupBoxCondition_DAA";
            groupBoxCondition_DAA.Size = new Size(527, 277);
            groupBoxCondition_DAA.TabIndex = 0;
            groupBoxCondition_DAA.TabStop = false;
            groupBoxCondition_DAA.Text = "Условие";
            // 
            // textBoxCondition_DAA
            // 
            textBoxCondition_DAA.Location = new Point(14, 35);
            textBoxCondition_DAA.Multiline = true;
            textBoxCondition_DAA.Name = "textBoxCondition_DAA";
            textBoxCondition_DAA.ReadOnly = true;
            textBoxCondition_DAA.Size = new Size(407, 85);
            textBoxCondition_DAA.TabIndex = 0;
            textBoxCondition_DAA.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в таблицу.\r\n";
            // 
            // groupBoxInput_DAA
            // 
            groupBoxInput_DAA.Controls.Add(textBoxStop_DAA);
            groupBoxInput_DAA.Controls.Add(labelStop_DAA);
            groupBoxInput_DAA.Controls.Add(textBoxStart_DAA);
            groupBoxInput_DAA.Controls.Add(labelStart_DAA);
            groupBoxInput_DAA.Location = new Point(25, 311);
            groupBoxInput_DAA.Name = "groupBoxInput_DAA";
            groupBoxInput_DAA.Size = new Size(317, 127);
            groupBoxInput_DAA.TabIndex = 1;
            groupBoxInput_DAA.TabStop = false;
            groupBoxInput_DAA.Text = "Ввод данных";
            // 
            // textBoxStop_DAA
            // 
            textBoxStop_DAA.Location = new Point(176, 72);
            textBoxStop_DAA.Name = "textBoxStop_DAA";
            textBoxStop_DAA.Size = new Size(125, 27);
            textBoxStop_DAA.TabIndex = 3;
            // 
            // labelStop_DAA
            // 
            labelStop_DAA.Location = new Point(176, 39);
            labelStop_DAA.Name = "labelStop_DAA";
            labelStop_DAA.ReadOnly = true;
            labelStop_DAA.Size = new Size(125, 27);
            labelStop_DAA.TabIndex = 2;
            labelStop_DAA.Text = "Стоп шага";
            // 
            // textBoxStart_DAA
            // 
            textBoxStart_DAA.Location = new Point(17, 74);
            textBoxStart_DAA.Name = "textBoxStart_DAA";
            textBoxStart_DAA.Size = new Size(125, 27);
            textBoxStart_DAA.TabIndex = 1;
            // 
            // labelStart_DAA
            // 
            labelStart_DAA.Location = new Point(15, 35);
            labelStart_DAA.Name = "labelStart_DAA";
            labelStart_DAA.ReadOnly = true;
            labelStart_DAA.Size = new Size(125, 27);
            labelStart_DAA.TabIndex = 0;
            labelStart_DAA.Text = "Старт шага";
            // 
            // buttonHelp_DAA
            // 
            buttonHelp_DAA.BackColor = SystemColors.Highlight;
            buttonHelp_DAA.Location = new Point(355, 355);
            buttonHelp_DAA.Name = "buttonHelp_DAA";
            buttonHelp_DAA.Size = new Size(81, 57);
            buttonHelp_DAA.TabIndex = 2;
            buttonHelp_DAA.Text = "Справка";
            buttonHelp_DAA.UseVisualStyleBackColor = false;
            buttonHelp_DAA.Click += buttonHelp_DAA_Click;
            // 
            // buttonResult_DAA
            // 
            buttonResult_DAA.BackColor = Color.FromArgb(255, 128, 128);
            buttonResult_DAA.Location = new Point(447, 358);
            buttonResult_DAA.Name = "buttonResult_DAA";
            buttonResult_DAA.Size = new Size(104, 52);
            buttonResult_DAA.TabIndex = 3;
            buttonResult_DAA.Text = "Выполнить";
            buttonResult_DAA.UseVisualStyleBackColor = false;
            buttonResult_DAA.Click += buttonResult_DAA_Click;
            // 
            // groupBoxResult_DAA
            // 
            groupBoxResult_DAA.Controls.Add(textBoxResult_DAA);
            groupBoxResult_DAA.Controls.Add(labelResult_DAA);
            groupBoxResult_DAA.Location = new Point(556, 35);
            groupBoxResult_DAA.Name = "groupBoxResult_DAA";
            groupBoxResult_DAA.Size = new Size(232, 377);
            groupBoxResult_DAA.TabIndex = 4;
            groupBoxResult_DAA.TabStop = false;
            groupBoxResult_DAA.Text = "Вывод данных";
            // 
            // textBoxResult_DAA
            // 
            textBoxResult_DAA.Location = new Point(16, 61);
            textBoxResult_DAA.Multiline = true;
            textBoxResult_DAA.Name = "textBoxResult_DAA";
            textBoxResult_DAA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_DAA.Size = new Size(210, 298);
            textBoxResult_DAA.TabIndex = 1;
            // 
            // labelResult_DAA
            // 
            labelResult_DAA.Location = new Point(13, 27);
            labelResult_DAA.Name = "labelResult_DAA";
            labelResult_DAA.ReadOnly = true;
            labelResult_DAA.Size = new Size(125, 27);
            labelResult_DAA.TabIndex = 0;
            labelResult_DAA.Text = "Результат";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxResult_DAA);
            Controls.Add(buttonResult_DAA);
            Controls.Add(buttonHelp_DAA);
            Controls.Add(groupBoxInput_DAA);
            Controls.Add(groupBoxCondition_DAA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 10 | Девятерикова А.А.";
            groupBoxCondition_DAA.ResumeLayout(false);
            groupBoxCondition_DAA.PerformLayout();
            groupBoxInput_DAA.ResumeLayout(false);
            groupBoxInput_DAA.PerformLayout();
            groupBoxResult_DAA.ResumeLayout(false);
            groupBoxResult_DAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_DAA;
        private TextBox textBoxCondition_DAA;
        private GroupBox groupBoxInput_DAA;
        private TextBox textBoxStop_DAA;
        private TextBox labelStop_DAA;
        private TextBox textBoxStart_DAA;
        private TextBox labelStart_DAA;
        private Button buttonHelp_DAA;
        private Button buttonResult_DAA;
        private GroupBox groupBoxResult_DAA;
        private TextBox textBoxResult_DAA;
        private TextBox labelResult_DAA;
    }
}
