namespace Tyuiu.DewjaterikowaAA.Sprint6.Task2.V9
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
            textBoxCondition_DAA = new TextBox();
            groupBoxInput_DAA = new GroupBox();
            textBoxStop_DAA = new TextBox();
            labelStop_DAA = new TextBox();
            textBoxStart_DAA = new TextBox();
            labelStart_DAA = new TextBox();
            buttonHelp_DAA = new Button();
            buttonResult_DAA = new Button();
            groupBoxResult_DAA = new GroupBox();
            chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewResult_DAA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            textBoxResult_DAA = new TextBox();
            groupBoxCondition_DAA.SuspendLayout();
            groupBoxInput_DAA.SuspendLayout();
            groupBoxResult_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_DAA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_DAA
            // 
            groupBoxCondition_DAA.Controls.Add(textBoxCondition_DAA);
            groupBoxCondition_DAA.Location = new Point(12, 12);
            groupBoxCondition_DAA.Name = "groupBoxCondition_DAA";
            groupBoxCondition_DAA.Size = new Size(468, 306);
            groupBoxCondition_DAA.TabIndex = 0;
            groupBoxCondition_DAA.TabStop = false;
            groupBoxCondition_DAA.Text = "Условие";
            // 
            // textBoxCondition_DAA
            // 
            textBoxCondition_DAA.Location = new Point(13, 28);
            textBoxCondition_DAA.Multiline = true;
            textBoxCondition_DAA.Name = "textBoxCondition_DAA";
            textBoxCondition_DAA.ReadOnly = true;
            textBoxCondition_DAA.Size = new Size(450, 88);
            textBoxCondition_DAA.TabIndex = 0;
            textBoxCondition_DAA.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы.\r\n\r\n";
            // 
            // groupBoxInput_DAA
            // 
            groupBoxInput_DAA.Controls.Add(textBoxStop_DAA);
            groupBoxInput_DAA.Controls.Add(labelStop_DAA);
            groupBoxInput_DAA.Controls.Add(textBoxStart_DAA);
            groupBoxInput_DAA.Controls.Add(labelStart_DAA);
            groupBoxInput_DAA.Location = new Point(14, 336);
            groupBoxInput_DAA.Name = "groupBoxInput_DAA";
            groupBoxInput_DAA.Size = new Size(262, 102);
            groupBoxInput_DAA.TabIndex = 1;
            groupBoxInput_DAA.TabStop = false;
            groupBoxInput_DAA.Text = "Ввод данных";
            // 
            // textBoxStop_DAA
            // 
            textBoxStop_DAA.Location = new Point(137, 59);
            textBoxStop_DAA.Name = "textBoxStop_DAA";
            textBoxStop_DAA.Size = new Size(119, 27);
            textBoxStop_DAA.TabIndex = 3;
            // 
            // labelStop_DAA
            // 
            labelStop_DAA.Location = new Point(137, 26);
            labelStop_DAA.Name = "labelStop_DAA";
            labelStop_DAA.ReadOnly = true;
            labelStop_DAA.Size = new Size(119, 27);
            labelStop_DAA.TabIndex = 2;
            labelStop_DAA.Text = "Стоп шага";
            // 
            // textBoxStart_DAA
            // 
            textBoxStart_DAA.Location = new Point(6, 59);
            textBoxStart_DAA.Name = "textBoxStart_DAA";
            textBoxStart_DAA.Size = new Size(125, 27);
            textBoxStart_DAA.TabIndex = 1;
            // 
            // labelStart_DAA
            // 
            labelStart_DAA.Location = new Point(6, 26);
            labelStart_DAA.Name = "labelStart_DAA";
            labelStart_DAA.ReadOnly = true;
            labelStart_DAA.Size = new Size(125, 27);
            labelStart_DAA.TabIndex = 0;
            labelStart_DAA.Text = "Старт шага";
            // 
            // buttonHelp_DAA
            // 
            buttonHelp_DAA.BackColor = SystemColors.ActiveCaption;
            buttonHelp_DAA.Location = new Point(276, 348);
            buttonHelp_DAA.Name = "buttonHelp_DAA";
            buttonHelp_DAA.Size = new Size(89, 74);
            buttonHelp_DAA.TabIndex = 2;
            buttonHelp_DAA.Text = "Справка";
            buttonHelp_DAA.UseVisualStyleBackColor = false;
            buttonHelp_DAA.Click += buttonHelp_DAA_Click;
            // 
            // buttonResult_DAA
            // 
            buttonResult_DAA.Location = new Point(371, 348);
            buttonResult_DAA.Name = "buttonResult_DAA";
            buttonResult_DAA.Size = new Size(118, 74);
            buttonResult_DAA.TabIndex = 3;
            buttonResult_DAA.Text = "Выполнить";
            buttonResult_DAA.UseVisualStyleBackColor = true;
            buttonResult_DAA.Click += buttonResult_DAA_Click;
            buttonResult_DAA.MouseDown += buttonResult_DAA_MouseDown;
            buttonResult_DAA.MouseEnter += buttonResult_DAA_MouseEnter;
            buttonResult_DAA.MouseLeave += buttonResult_DAA_MouseLeave;
            // 
            // groupBoxResult_DAA
            // 
            groupBoxResult_DAA.Controls.Add(chartResult);
            groupBoxResult_DAA.Controls.Add(dataGridViewResult_DAA);
            groupBoxResult_DAA.Controls.Add(textBoxResult_DAA);
            groupBoxResult_DAA.Location = new Point(495, 23);
            groupBoxResult_DAA.Name = "groupBoxResult_DAA";
            groupBoxResult_DAA.Size = new Size(462, 399);
            groupBoxResult_DAA.TabIndex = 4;
            groupBoxResult_DAA.TabStop = false;
            groupBoxResult_DAA.Text = "Вывод данных";
            // 
            // chartResult
            // 
            chartArea1.Name = "ChartArea1";
            chartResult.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResult.Legends.Add(legend1);
            chartResult.Location = new Point(166, 50);
            chartResult.Name = "chartResult";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult.Series.Add(series1);
            chartResult.Size = new Size(296, 316);
            chartResult.TabIndex = 2;
            chartResult.Text = "chart1";
            // 
            // dataGridViewResult_DAA
            // 
            dataGridViewResult_DAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_DAA.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewResult_DAA.Location = new Point(11, 58);
            dataGridViewResult_DAA.Name = "dataGridViewResult_DAA";
            dataGridViewResult_DAA.RowHeadersVisible = false;
            dataGridViewResult_DAA.RowHeadersWidth = 51;
            dataGridViewResult_DAA.Size = new Size(106, 308);
            dataGridViewResult_DAA.TabIndex = 1;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // textBoxResult_DAA
            // 
            textBoxResult_DAA.Location = new Point(11, 23);
            textBoxResult_DAA.Name = "textBoxResult_DAA";
            textBoxResult_DAA.ReadOnly = true;
            textBoxResult_DAA.Size = new Size(106, 27);
            textBoxResult_DAA.TabIndex = 0;
            textBoxResult_DAA.Text = "Результат";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 450);
            Controls.Add(groupBoxResult_DAA);
            Controls.Add(buttonResult_DAA);
            Controls.Add(buttonHelp_DAA);
            Controls.Add(groupBoxInput_DAA);
            Controls.Add(groupBoxCondition_DAA);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 9 | Девятерикова А.А.";
            groupBoxCondition_DAA.ResumeLayout(false);
            groupBoxCondition_DAA.PerformLayout();
            groupBoxInput_DAA.ResumeLayout(false);
            groupBoxInput_DAA.PerformLayout();
            groupBoxResult_DAA.ResumeLayout(false);
            groupBoxResult_DAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_DAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_DAA;
        private TextBox textBoxCondition_DAA;
        private GroupBox groupBoxInput_DAA;
        private TextBox labelStop_DAA;
        private TextBox textBoxStart_DAA;
        private TextBox labelStart_DAA;
        private TextBox textBoxStop_DAA;
        private Button buttonHelp_DAA;
        private Button buttonResult_DAA;
        private GroupBox groupBoxResult_DAA;
        private DataGridView dataGridViewResult_DAA;
        private TextBox textBoxResult_DAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
    }
}
