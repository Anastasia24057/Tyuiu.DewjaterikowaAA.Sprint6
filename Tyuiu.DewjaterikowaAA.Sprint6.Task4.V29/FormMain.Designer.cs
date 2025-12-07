namespace Tyuiu.DewjaterikowaAA.Sprint6.Task4.V29
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelCondition_DAA = new Panel();
            buttonDone_DAA = new Button();
            buttonSave_DAA = new Button();
            buttonHelp_DAA = new Button();
            groupBoxInput_DAA = new GroupBox();
            textBoxStop_DAA = new TextBox();
            textBoxStopStep_DAA = new TextBox();
            textBoxStartStep_DAA = new TextBox();
            textBoxStart_DAA = new TextBox();
            groupBoxCondition_DAA = new GroupBox();
            textBoxCondition_DAA = new TextBox();
            panelOutput_DAA = new Panel();
            groupBoxOutput_DAA = new GroupBox();
            textBoxResult_DAA = new TextBox();
            panelFunction_DAA = new Panel();
            chartFunction_DAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelCondition_DAA.SuspendLayout();
            groupBoxInput_DAA.SuspendLayout();
            groupBoxCondition_DAA.SuspendLayout();
            panelOutput_DAA.SuspendLayout();
            groupBoxOutput_DAA.SuspendLayout();
            panelFunction_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_DAA).BeginInit();
            SuspendLayout();
            // 
            // panelCondition_DAA
            // 
            panelCondition_DAA.BackColor = Color.FromArgb(255, 192, 192);
            panelCondition_DAA.Controls.Add(buttonDone_DAA);
            panelCondition_DAA.Controls.Add(buttonSave_DAA);
            panelCondition_DAA.Controls.Add(buttonHelp_DAA);
            panelCondition_DAA.Controls.Add(groupBoxInput_DAA);
            panelCondition_DAA.Controls.Add(groupBoxCondition_DAA);
            panelCondition_DAA.Dock = DockStyle.Top;
            panelCondition_DAA.Location = new Point(0, 0);
            panelCondition_DAA.Name = "panelCondition_DAA";
            panelCondition_DAA.Size = new Size(962, 105);
            panelCondition_DAA.TabIndex = 0;
            // 
            // buttonDone_DAA
            // 
            buttonDone_DAA.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone_DAA.Location = new Point(657, 36);
            buttonDone_DAA.Name = "buttonDone_DAA";
            buttonDone_DAA.Size = new Size(102, 51);
            buttonDone_DAA.TabIndex = 2;
            buttonDone_DAA.Text = "Выполнить";
            buttonDone_DAA.UseVisualStyleBackColor = false;
            buttonDone_DAA.Click += buttonDone_DAA_Click;
            // 
            // buttonSave_DAA
            // 
            buttonSave_DAA.BackColor = Color.FromArgb(255, 128, 128);
            buttonSave_DAA.Location = new Point(765, 35);
            buttonSave_DAA.Name = "buttonSave_DAA";
            buttonSave_DAA.Size = new Size(92, 51);
            buttonSave_DAA.TabIndex = 2;
            buttonSave_DAA.Text = "Сохранить";
            buttonSave_DAA.UseVisualStyleBackColor = false;
            buttonSave_DAA.Click += buttonSave_DAA_Click;
            // 
            // buttonHelp_DAA
            // 
            buttonHelp_DAA.BackColor = Color.FromArgb(192, 255, 255);
            buttonHelp_DAA.Location = new Point(863, 35);
            buttonHelp_DAA.Name = "buttonHelp_DAA";
            buttonHelp_DAA.Size = new Size(87, 51);
            buttonHelp_DAA.TabIndex = 2;
            buttonHelp_DAA.Text = "Справка";
            buttonHelp_DAA.UseVisualStyleBackColor = false;
            buttonHelp_DAA.Click += buttonHelp_DAA_Click;
            // 
            // groupBoxInput_DAA
            // 
            groupBoxInput_DAA.Controls.Add(textBoxStop_DAA);
            groupBoxInput_DAA.Controls.Add(textBoxStopStep_DAA);
            groupBoxInput_DAA.Controls.Add(textBoxStartStep_DAA);
            groupBoxInput_DAA.Controls.Add(textBoxStart_DAA);
            groupBoxInput_DAA.Location = new Point(378, 12);
            groupBoxInput_DAA.Name = "groupBoxInput_DAA";
            groupBoxInput_DAA.Size = new Size(273, 83);
            groupBoxInput_DAA.TabIndex = 1;
            groupBoxInput_DAA.TabStop = false;
            groupBoxInput_DAA.Text = "Ввод данных";
            // 
            // textBoxStop_DAA
            // 
            textBoxStop_DAA.Location = new Point(137, 20);
            textBoxStop_DAA.Name = "textBoxStop_DAA";
            textBoxStop_DAA.ReadOnly = true;
            textBoxStop_DAA.Size = new Size(125, 27);
            textBoxStop_DAA.TabIndex = 0;
            textBoxStop_DAA.Text = "Стоп шага";
            // 
            // textBoxStopStep_DAA
            // 
            textBoxStopStep_DAA.Location = new Point(137, 49);
            textBoxStopStep_DAA.Name = "textBoxStopStep_DAA";
            textBoxStopStep_DAA.Size = new Size(125, 27);
            textBoxStopStep_DAA.TabIndex = 0;
            // 
            // textBoxStartStep_DAA
            // 
            textBoxStartStep_DAA.Location = new Point(6, 49);
            textBoxStartStep_DAA.Name = "textBoxStartStep_DAA";
            textBoxStartStep_DAA.Size = new Size(125, 27);
            textBoxStartStep_DAA.TabIndex = 0;
            // 
            // textBoxStart_DAA
            // 
            textBoxStart_DAA.Location = new Point(6, 20);
            textBoxStart_DAA.Name = "textBoxStart_DAA";
            textBoxStart_DAA.ReadOnly = true;
            textBoxStart_DAA.Size = new Size(125, 27);
            textBoxStart_DAA.TabIndex = 0;
            textBoxStart_DAA.Text = "Старт шага";
            // 
            // groupBoxCondition_DAA
            // 
            groupBoxCondition_DAA.Controls.Add(textBoxCondition_DAA);
            groupBoxCondition_DAA.Location = new Point(8, 12);
            groupBoxCondition_DAA.Name = "groupBoxCondition_DAA";
            groupBoxCondition_DAA.Size = new Size(370, 87);
            groupBoxCondition_DAA.TabIndex = 0;
            groupBoxCondition_DAA.TabStop = false;
            groupBoxCondition_DAA.Text = "Условие";
            // 
            // textBoxCondition_DAA
            // 
            textBoxCondition_DAA.Location = new Point(12, 17);
            textBoxCondition_DAA.Multiline = true;
            textBoxCondition_DAA.Name = "textBoxCondition_DAA";
            textBoxCondition_DAA.ReadOnly = true;
            textBoxCondition_DAA.Size = new Size(352, 66);
            textBoxCondition_DAA.TabIndex = 0;
            textBoxCondition_DAA.Text = "Протабулировать функцию на заданном диапазоне.\r\nCохранить в файл OutPutFileTask4V29\r\n\r\n";
            // 
            // panelOutput_DAA
            // 
            panelOutput_DAA.BackColor = Color.FromArgb(192, 255, 255);
            panelOutput_DAA.Controls.Add(groupBoxOutput_DAA);
            panelOutput_DAA.Dock = DockStyle.Left;
            panelOutput_DAA.Location = new Point(0, 105);
            panelOutput_DAA.Name = "panelOutput_DAA";
            panelOutput_DAA.Padding = new Padding(5);
            panelOutput_DAA.Size = new Size(250, 355);
            panelOutput_DAA.TabIndex = 0;
            // 
            // groupBoxOutput_DAA
            // 
            groupBoxOutput_DAA.Controls.Add(textBoxResult_DAA);
            groupBoxOutput_DAA.Dock = DockStyle.Fill;
            groupBoxOutput_DAA.Location = new Point(5, 5);
            groupBoxOutput_DAA.Name = "groupBoxOutput_DAA";
            groupBoxOutput_DAA.Size = new Size(240, 345);
            groupBoxOutput_DAA.TabIndex = 0;
            groupBoxOutput_DAA.TabStop = false;
            groupBoxOutput_DAA.Text = "Вывод данных";
            // 
            // textBoxResult_DAA
            // 
            textBoxResult_DAA.Dock = DockStyle.Fill;
            textBoxResult_DAA.Location = new Point(3, 23);
            textBoxResult_DAA.Multiline = true;
            textBoxResult_DAA.Name = "textBoxResult_DAA";
            textBoxResult_DAA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_DAA.Size = new Size(234, 319);
            textBoxResult_DAA.TabIndex = 0;
            // 
            // panelFunction_DAA
            // 
            panelFunction_DAA.BackColor = Color.FromArgb(255, 192, 255);
            panelFunction_DAA.Controls.Add(chartFunction_DAA);
            panelFunction_DAA.Dock = DockStyle.Fill;
            panelFunction_DAA.Location = new Point(250, 105);
            panelFunction_DAA.Name = "panelFunction_DAA";
            panelFunction_DAA.Size = new Size(712, 355);
            panelFunction_DAA.TabIndex = 0;
            // 
            // chartFunction_DAA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_DAA.ChartAreas.Add(chartArea1);
            chartFunction_DAA.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_DAA.Legends.Add(legend1);
            chartFunction_DAA.Location = new Point(0, 0);
            chartFunction_DAA.Name = "chartFunction_DAA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_DAA.Series.Add(series1);
            chartFunction_DAA.Size = new Size(712, 355);
            chartFunction_DAA.TabIndex = 0;
            chartFunction_DAA.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График функции";
            chartFunction_DAA.Titles.Add(title1);
            // 
            // splitter1
            // 
            splitter1.Location = new Point(250, 105);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 355);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 460);
            Controls.Add(splitter1);
            Controls.Add(panelFunction_DAA);
            Controls.Add(panelOutput_DAA);
            Controls.Add(panelCondition_DAA);
            MinimumSize = new Size(980, 507);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 29| Девятерикова А.А.";
            panelCondition_DAA.ResumeLayout(false);
            groupBoxInput_DAA.ResumeLayout(false);
            groupBoxInput_DAA.PerformLayout();
            groupBoxCondition_DAA.ResumeLayout(false);
            groupBoxCondition_DAA.PerformLayout();
            panelOutput_DAA.ResumeLayout(false);
            groupBoxOutput_DAA.ResumeLayout(false);
            groupBoxOutput_DAA.PerformLayout();
            panelFunction_DAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_DAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCondition_DAA;
        private Panel panelOutput_DAA;
        private Panel panelFunction_DAA;
        private Splitter splitter1;
        private GroupBox groupBoxOutput_DAA;
        private TextBox textBoxResult_DAA;
        private GroupBox groupBoxCondition_DAA;
        private TextBox textBoxCondition_DAA;
        private GroupBox groupBoxInput_DAA;
        private TextBox textBoxStop_DAA;
        private TextBox textBoxStopStep_DAA;
        private TextBox textBoxStartStep_DAA;
        private TextBox textBoxStart_DAA;
        private Button buttonHelp_DAA;
        private Button buttonDone_DAA;
        private Button buttonSave_DAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_DAA;
    }
}
