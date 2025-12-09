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
            panelClick_DAA = new Panel();
            buttonHelp_DAA = new Button();
            buttonDone_DAA = new Button();
            buttonOpenFile_DAA = new Button();
            panelCondition_DAA = new Panel();
            groupBoxCondition_DAA = new GroupBox();
            textBox1 = new TextBox();
            panelInput_DAA = new Panel();
            groupBoxInput_DAA = new GroupBox();
            textBoxInput_DAA = new TextBox();
            panelResult_DAA = new Panel();
            groupBoxResult_DAA = new GroupBox();
            textBoxResult_DAA = new TextBox();
            openFileDialogTask_DAA = new OpenFileDialog();
            toolTipTask_DAA = new ToolTip(components);
            splitter1 = new Splitter();
            panelClick_DAA.SuspendLayout();
            panelCondition_DAA.SuspendLayout();
            groupBoxCondition_DAA.SuspendLayout();
            panelInput_DAA.SuspendLayout();
            groupBoxInput_DAA.SuspendLayout();
            panelResult_DAA.SuspendLayout();
            groupBoxResult_DAA.SuspendLayout();
            SuspendLayout();
            // 
            // panelClick_DAA
            // 
            panelClick_DAA.Controls.Add(buttonHelp_DAA);
            panelClick_DAA.Controls.Add(buttonDone_DAA);
            panelClick_DAA.Controls.Add(buttonOpenFile_DAA);
            panelClick_DAA.Dock = DockStyle.Top;
            panelClick_DAA.Location = new Point(0, 0);
            panelClick_DAA.Name = "panelClick_DAA";
            panelClick_DAA.Size = new Size(909, 82);
            panelClick_DAA.TabIndex = 1;
            // 
            // buttonHelp_DAA
            // 
            buttonHelp_DAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_DAA.Image = Properties.Resources.information;
            buttonHelp_DAA.Location = new Point(768, 17);
            buttonHelp_DAA.Name = "buttonHelp_DAA";
            buttonHelp_DAA.Size = new Size(103, 59);
            buttonHelp_DAA.TabIndex = 2;
            toolTipTask_DAA.SetToolTip(buttonHelp_DAA, "Информация о разработчике");
            buttonHelp_DAA.UseVisualStyleBackColor = true;
            buttonHelp_DAA.Click += buttonHelp_DAA_Click;
            // 
            // buttonDone_DAA
            // 
            buttonDone_DAA.Image = Properties.Resources.application_go;
            buttonDone_DAA.Location = new Point(126, 15);
            buttonDone_DAA.Name = "buttonDone_DAA";
            buttonDone_DAA.Size = new Size(124, 61);
            buttonDone_DAA.TabIndex = 1;
            toolTipTask_DAA.SetToolTip(buttonDone_DAA, "Производит поиск в файле вхождений слов с буквой \"n\" и контактенирует строки, в которых находятся эти слова");
            buttonDone_DAA.UseVisualStyleBackColor = true;
            buttonDone_DAA.Click += buttonDone_DAA_Click;
            // 
            // buttonOpenFile_DAA
            // 
            buttonOpenFile_DAA.Image = Properties.Resources.folder_explore;
            buttonOpenFile_DAA.Location = new Point(7, 14);
            buttonOpenFile_DAA.Name = "buttonOpenFile_DAA";
            buttonOpenFile_DAA.Size = new Size(114, 62);
            buttonOpenFile_DAA.TabIndex = 0;
            toolTipTask_DAA.SetToolTip(buttonOpenFile_DAA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n\r\n");
            buttonOpenFile_DAA.Click += buttonOpenFile_DAA_Click;
            // 
            // panelCondition_DAA
            // 
            panelCondition_DAA.Controls.Add(groupBoxCondition_DAA);
            panelCondition_DAA.Dock = DockStyle.Top;
            panelCondition_DAA.Location = new Point(0, 82);
            panelCondition_DAA.Name = "panelCondition_DAA";
            panelCondition_DAA.Size = new Size(909, 87);
            panelCondition_DAA.TabIndex = 2;
            // 
            // groupBoxCondition_DAA
            // 
            groupBoxCondition_DAA.Controls.Add(textBox1);
            groupBoxCondition_DAA.Dock = DockStyle.Fill;
            groupBoxCondition_DAA.Location = new Point(0, 0);
            groupBoxCondition_DAA.Name = "groupBoxCondition_DAA";
            groupBoxCondition_DAA.Size = new Size(909, 87);
            groupBoxCondition_DAA.TabIndex = 0;
            groupBoxCondition_DAA.TabStop = false;
            groupBoxCondition_DAA.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(903, 61);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panelInput_DAA
            // 
            panelInput_DAA.Controls.Add(groupBoxInput_DAA);
            panelInput_DAA.Dock = DockStyle.Left;
            panelInput_DAA.Location = new Point(0, 169);
            panelInput_DAA.Name = "panelInput_DAA";
            panelInput_DAA.Size = new Size(250, 339);
            panelInput_DAA.TabIndex = 3;
            // 
            // groupBoxInput_DAA
            // 
            groupBoxInput_DAA.Controls.Add(textBoxInput_DAA);
            groupBoxInput_DAA.Dock = DockStyle.Fill;
            groupBoxInput_DAA.Location = new Point(0, 0);
            groupBoxInput_DAA.Name = "groupBoxInput_DAA";
            groupBoxInput_DAA.Size = new Size(250, 339);
            groupBoxInput_DAA.TabIndex = 0;
            groupBoxInput_DAA.TabStop = false;
            groupBoxInput_DAA.Text = "Ввод";
            // 
            // textBoxInput_DAA
            // 
            textBoxInput_DAA.Dock = DockStyle.Fill;
            textBoxInput_DAA.Location = new Point(3, 23);
            textBoxInput_DAA.Multiline = true;
            textBoxInput_DAA.Name = "textBoxInput_DAA";
            textBoxInput_DAA.ScrollBars = ScrollBars.Vertical;
            textBoxInput_DAA.Size = new Size(244, 313);
            textBoxInput_DAA.TabIndex = 0;
            // 
            // panelResult_DAA
            // 
            panelResult_DAA.Controls.Add(groupBoxResult_DAA);
            panelResult_DAA.Dock = DockStyle.Fill;
            panelResult_DAA.Location = new Point(250, 169);
            panelResult_DAA.Name = "panelResult_DAA";
            panelResult_DAA.Size = new Size(659, 339);
            panelResult_DAA.TabIndex = 4;
            // 
            // groupBoxResult_DAA
            // 
            groupBoxResult_DAA.Controls.Add(textBoxResult_DAA);
            groupBoxResult_DAA.Dock = DockStyle.Fill;
            groupBoxResult_DAA.Location = new Point(0, 0);
            groupBoxResult_DAA.Name = "groupBoxResult_DAA";
            groupBoxResult_DAA.Size = new Size(659, 339);
            groupBoxResult_DAA.TabIndex = 0;
            groupBoxResult_DAA.TabStop = false;
            groupBoxResult_DAA.Text = "Вывод";
            // 
            // textBoxResult_DAA
            // 
            textBoxResult_DAA.Dock = DockStyle.Fill;
            textBoxResult_DAA.Location = new Point(3, 23);
            textBoxResult_DAA.Multiline = true;
            textBoxResult_DAA.Name = "textBoxResult_DAA";
            textBoxResult_DAA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_DAA.Size = new Size(653, 313);
            textBoxResult_DAA.TabIndex = 0;
            // 
            // openFileDialogTask_DAA
            // 
            openFileDialogTask_DAA.FileName = "openFileDialogTask_DAA";
            // 
            // toolTipTask_DAA
            // 
            toolTipTask_DAA.ToolTipTitle = "Подсказка";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(250, 169);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 339);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 508);
            Controls.Add(splitter1);
            Controls.Add(panelResult_DAA);
            Controls.Add(panelInput_DAA);
            Controls.Add(panelCondition_DAA);
            Controls.Add(panelClick_DAA);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 18 | Девятерикова А.А.";
            panelClick_DAA.ResumeLayout(false);
            panelCondition_DAA.ResumeLayout(false);
            groupBoxCondition_DAA.ResumeLayout(false);
            groupBoxCondition_DAA.PerformLayout();
            panelInput_DAA.ResumeLayout(false);
            groupBoxInput_DAA.ResumeLayout(false);
            groupBoxInput_DAA.PerformLayout();
            panelResult_DAA.ResumeLayout(false);
            groupBoxResult_DAA.ResumeLayout(false);
            groupBoxResult_DAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelClick_DAA;
        private Panel panelCondition_DAA;
        private GroupBox groupBoxCondition_DAA;
        private Panel panelInput_DAA;
        private GroupBox groupBoxInput_DAA;
        private TextBox textBoxInput_DAA;
        private Panel panelResult_DAA;
        private GroupBox groupBoxResult_DAA;
        private TextBox textBoxResult_DAA;
        private Button buttonDone_DAA;
        private Button buttonOpenFile_DAA;
        private TextBox textBox1;
        private OpenFileDialog openFileDialogTask_DAA;
        private ToolTip toolTipTask_DAA;
        private Button buttonHelp_DAA;
        private Splitter splitter1;
    }
}
