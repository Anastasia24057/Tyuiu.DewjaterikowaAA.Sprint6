namespace Tyuiu.DewjaterikowaAA.Sprint6.Task5.V4
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
            groupBoxCondition_DAA = new GroupBox();
            buttonHelp_DAA = new Button();
            buttonOpenFile_DAA = new Button();
            buttonDone_DAA = new Button();
            textBoxCondition_DAA = new TextBox();
            groupBoxOutput_DAA = new GroupBox();
            dataGridViewNums_DAA = new DataGridView();
            groupBoxDiag_DAA = new GroupBox();
            chartDiag_DAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxCondition_DAA.SuspendLayout();
            groupBoxOutput_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_DAA).BeginInit();
            groupBoxDiag_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag_DAA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_DAA
            // 
            groupBoxCondition_DAA.Controls.Add(buttonHelp_DAA);
            groupBoxCondition_DAA.Controls.Add(buttonOpenFile_DAA);
            groupBoxCondition_DAA.Controls.Add(buttonDone_DAA);
            groupBoxCondition_DAA.Controls.Add(textBoxCondition_DAA);
            groupBoxCondition_DAA.Dock = DockStyle.Top;
            groupBoxCondition_DAA.Location = new Point(0, 0);
            groupBoxCondition_DAA.Name = "groupBoxCondition_DAA";
            groupBoxCondition_DAA.Size = new Size(800, 107);
            groupBoxCondition_DAA.TabIndex = 0;
            groupBoxCondition_DAA.TabStop = false;
            groupBoxCondition_DAA.Text = "Условие";
            // 
            // buttonHelp_DAA
            // 
            buttonHelp_DAA.BackColor = Color.Lime;
            buttonHelp_DAA.Location = new Point(681, 36);
            buttonHelp_DAA.Name = "buttonHelp_DAA";
            buttonHelp_DAA.Size = new Size(94, 57);
            buttonHelp_DAA.TabIndex = 3;
            buttonHelp_DAA.Text = "Справка";
            buttonHelp_DAA.UseVisualStyleBackColor = false;
            buttonHelp_DAA.Click += buttonHelp_DAA_Click;
            // 
            // buttonOpenFile_DAA
            // 
            buttonOpenFile_DAA.BackColor = Color.FromArgb(128, 128, 255);
            buttonOpenFile_DAA.Location = new Point(567, 36);
            buttonOpenFile_DAA.Name = "buttonOpenFile_DAA";
            buttonOpenFile_DAA.Size = new Size(108, 57);
            buttonOpenFile_DAA.TabIndex = 2;
            buttonOpenFile_DAA.Text = "Открыть файл";
            buttonOpenFile_DAA.UseVisualStyleBackColor = false;
            buttonOpenFile_DAA.Click += buttonOpenFile_DAA_Click;
            // 
            // buttonDone_DAA
            // 
            buttonDone_DAA.BackColor = Color.FromArgb(255, 128, 128);
            buttonDone_DAA.Location = new Point(434, 36);
            buttonDone_DAA.Name = "buttonDone_DAA";
            buttonDone_DAA.Size = new Size(127, 57);
            buttonDone_DAA.TabIndex = 1;
            buttonDone_DAA.Text = "Выполнить";
            buttonDone_DAA.UseVisualStyleBackColor = false;
            buttonDone_DAA.Click += buttonDone_DAA_Click;
            // 
            // textBoxCondition_DAA
            // 
            textBoxCondition_DAA.Location = new Point(15, 26);
            textBoxCondition_DAA.Multiline = true;
            textBoxCondition_DAA.Name = "textBoxCondition_DAA";
            textBoxCondition_DAA.Size = new Size(413, 81);
            textBoxCondition_DAA.TabIndex = 0;
            textBoxCondition_DAA.Text = "Прочитать данные из файла InPutFileTask5V4.txt. Вывести в dataGridView. Вывести все целые числа.\r\n Построить диаграмму по этим значениям.";
            // 
            // groupBoxOutput_DAA
            // 
            groupBoxOutput_DAA.Controls.Add(dataGridViewNums_DAA);
            groupBoxOutput_DAA.Dock = DockStyle.Left;
            groupBoxOutput_DAA.Location = new Point(0, 107);
            groupBoxOutput_DAA.Name = "groupBoxOutput_DAA";
            groupBoxOutput_DAA.Size = new Size(254, 343);
            groupBoxOutput_DAA.TabIndex = 1;
            groupBoxOutput_DAA.TabStop = false;
            groupBoxOutput_DAA.Text = "Вывод данных";
            // 
            // dataGridViewNums_DAA
            // 
            dataGridViewNums_DAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_DAA.Location = new Point(8, 29);
            dataGridViewNums_DAA.Name = "dataGridViewNums_DAA";
            dataGridViewNums_DAA.RowHeadersWidth = 51;
            dataGridViewNums_DAA.Size = new Size(246, 308);
            dataGridViewNums_DAA.TabIndex = 0;
            // 
            // groupBoxDiag_DAA
            // 
            groupBoxDiag_DAA.Controls.Add(chartDiag_DAA);
            groupBoxDiag_DAA.Dock = DockStyle.Fill;
            groupBoxDiag_DAA.Location = new Point(254, 107);
            groupBoxDiag_DAA.Name = "groupBoxDiag_DAA";
            groupBoxDiag_DAA.Size = new Size(546, 343);
            groupBoxDiag_DAA.TabIndex = 2;
            groupBoxDiag_DAA.TabStop = false;
            groupBoxDiag_DAA.Text = "Диаграмма";
            // 
            // chartDiag_DAA
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag_DAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiag_DAA.Legends.Add(legend1);
            chartDiag_DAA.Location = new Point(33, 45);
            chartDiag_DAA.Name = "chartDiag_DAA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag_DAA.Series.Add(series1);
            chartDiag_DAA.Size = new Size(465, 262);
            chartDiag_DAA.TabIndex = 0;
            chartDiag_DAA.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxDiag_DAA);
            Controls.Add(groupBoxOutput_DAA);
            Controls.Add(groupBoxCondition_DAA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 4 | Девятерикова А.А. ";
            groupBoxCondition_DAA.ResumeLayout(false);
            groupBoxCondition_DAA.PerformLayout();
            groupBoxOutput_DAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_DAA).EndInit();
            groupBoxDiag_DAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiag_DAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_DAA;
        private TextBox textBoxCondition_DAA;
        private GroupBox groupBoxOutput_DAA;
        private DataGridView dataGridViewNums_DAA;
        private GroupBox groupBoxDiag_DAA;
        private Button buttonHelp_DAA;
        private Button buttonOpenFile_DAA;
        private Button buttonDone_DAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_DAA;
    }
}
