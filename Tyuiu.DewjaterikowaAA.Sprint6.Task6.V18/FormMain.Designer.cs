namespace Tyuiu.DewjaterikowaAA.Sprint6.Task6.V18
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            textBoxCond_DAA = new TextBox();
            textBoxCondition_DAA = new TextBox();
            buttonHelp_DAA = new Button();
            buttonDone_DAA = new Button();
            buttonOpenFile_DAA = new Button();
            panel2 = new Panel();
            groupBoxIn_DAA = new GroupBox();
            panel3 = new Panel();
            splitter1 = new Splitter();
            openFileDialog_DAA = new OpenFileDialog();
            toolTip_DAA = new ToolTip(components);
            textBoxInput_DAA = new TextBox();
            groupBoxResult_DAA = new GroupBox();
            textBoxResult_DAA = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxIn_DAA.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxResult_DAA.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxCond_DAA);
            panel1.Controls.Add(textBoxCondition_DAA);
            panel1.Controls.Add(buttonHelp_DAA);
            panel1.Controls.Add(buttonDone_DAA);
            panel1.Controls.Add(buttonOpenFile_DAA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 172);
            panel1.TabIndex = 0;
            // 
            // textBoxCond_DAA
            // 
            textBoxCond_DAA.Location = new Point(11, 98);
            textBoxCond_DAA.Multiline = true;
            textBoxCond_DAA.Name = "textBoxCond_DAA";
            textBoxCond_DAA.ReadOnly = true;
            textBoxCond_DAA.Size = new Size(907, 68);
            textBoxCond_DAA.TabIndex = 4;
            textBoxCond_DAA.Text = resources.GetString("textBoxCond_DAA.Text");
            // 
            // textBoxCondition_DAA
            // 
            textBoxCondition_DAA.Location = new Point(10, 67);
            textBoxCondition_DAA.Name = "textBoxCondition_DAA";
            textBoxCondition_DAA.ReadOnly = true;
            textBoxCondition_DAA.Size = new Size(125, 27);
            textBoxCondition_DAA.TabIndex = 3;
            textBoxCondition_DAA.Text = "Условие";
            // 
            // buttonHelp_DAA
            // 
            buttonHelp_DAA.Location = new Point(823, 15);
            buttonHelp_DAA.Name = "buttonHelp_DAA";
            buttonHelp_DAA.Size = new Size(95, 57);
            buttonHelp_DAA.TabIndex = 2;
            buttonHelp_DAA.Text = "button3";
            buttonHelp_DAA.UseVisualStyleBackColor = true;
            buttonHelp_DAA.Click += buttonHelp_DAA_Click;
            // 
            // buttonDone_DAA
            // 
            buttonDone_DAA.Image = Properties.Resources.application_go;
            buttonDone_DAA.Location = new Point(105, 9);
            buttonDone_DAA.Name = "buttonDone_DAA";
            buttonDone_DAA.Size = new Size(84, 59);
            buttonDone_DAA.TabIndex = 1;
            toolTip_DAA.SetToolTip(buttonDone_DAA, "Производит поиск в файле вхождений символов и конкатенирует те строки, в которых находятся данные символы");
            buttonDone_DAA.UseVisualStyleBackColor = true;
            buttonDone_DAA.Click += buttonDone_DAA_Click;
            // 
            // buttonOpenFile_DAA
            // 
            buttonOpenFile_DAA.Location = new Point(8, 9);
            buttonOpenFile_DAA.Name = "buttonOpenFile_DAA";
            buttonOpenFile_DAA.Size = new Size(91, 59);
            buttonOpenFile_DAA.TabIndex = 0;
            buttonOpenFile_DAA.Text = "button1";
            toolTip_DAA.SetToolTip(buttonOpenFile_DAA, "Открыть файл\r\nВыберите нужный файд для обработки\r\n\r\n\r\n");
            buttonOpenFile_DAA.UseVisualStyleBackColor = true;
            buttonOpenFile_DAA.Click += buttonOpenFile_DAA_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxIn_DAA);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 172);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 330);
            panel2.TabIndex = 0;
            // 
            // groupBoxIn_DAA
            // 
            groupBoxIn_DAA.Controls.Add(textBoxInput_DAA);
            groupBoxIn_DAA.Location = new Point(9, 7);
            groupBoxIn_DAA.Name = "groupBoxIn_DAA";
            groupBoxIn_DAA.Size = new Size(319, 320);
            groupBoxIn_DAA.TabIndex = 0;
            groupBoxIn_DAA.TabStop = false;
            groupBoxIn_DAA.Text = "Ввод";
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxResult_DAA);
            panel3.Controls.Add(splitter1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(334, 172);
            panel3.Name = "panel3";
            panel3.Size = new Size(610, 330);
            panel3.TabIndex = 1;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 330);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // openFileDialog_DAA
            // 
            openFileDialog_DAA.FileName = "openFileDialog1";
            // 
            // toolTip_DAA
            // 
            toolTip_DAA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_DAA.ToolTipTitle = "Подсказка";
            // 
            // textBoxInput_DAA
            // 
            textBoxInput_DAA.Location = new Point(9, 27);
            textBoxInput_DAA.Multiline = true;
            textBoxInput_DAA.Name = "textBoxInput_DAA";
            textBoxInput_DAA.Size = new Size(295, 284);
            textBoxInput_DAA.TabIndex = 0;
            // 
            // groupBoxResult_DAA
            // 
            groupBoxResult_DAA.Controls.Add(textBoxResult_DAA);
            groupBoxResult_DAA.Location = new Point(10, 7);
            groupBoxResult_DAA.Name = "groupBoxResult_DAA";
            groupBoxResult_DAA.Size = new Size(588, 311);
            groupBoxResult_DAA.TabIndex = 1;
            groupBoxResult_DAA.TabStop = false;
            groupBoxResult_DAA.Text = "Вывод";
            // 
            // textBoxResult_DAA
            // 
            textBoxResult_DAA.Location = new Point(11, 31);
            textBoxResult_DAA.Multiline = true;
            textBoxResult_DAA.Name = "textBoxResult_DAA";
            textBoxResult_DAA.Size = new Size(563, 274);
            textBoxResult_DAA.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 502);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 18 | Девятерикова А.А.";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxIn_DAA.ResumeLayout(false);
            groupBoxIn_DAA.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxResult_DAA.ResumeLayout(false);
            groupBoxResult_DAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonHelp_DAA;
        private Button buttonDone_DAA;
        private Button buttonOpenFile_DAA;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
        private TextBox textBoxCond_DAA;
        private TextBox textBoxCondition_DAA;
        private OpenFileDialog openFileDialog_DAA;
        private ToolTip toolTip_DAA;
        private GroupBox groupBoxIn_DAA;
        private TextBox textBoxInput_DAA;
        private GroupBox groupBoxResult_DAA;
        private TextBox textBoxResult_DAA;
    }
}
