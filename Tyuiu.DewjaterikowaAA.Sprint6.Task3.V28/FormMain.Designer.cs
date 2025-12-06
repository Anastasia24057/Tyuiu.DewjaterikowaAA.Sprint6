namespace Tyuiu.DewjaterikowaAA.Sprint6.Task3.V28
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
            dataGridViewMtrx_DAA = new DataGridView();
            textBoxCondition_DAA = new TextBox();
            groupBoxOutput_DAA = new GroupBox();
            dataGridViewMtrx2_DAA = new DataGridView();
            textBoxResult_DAA = new TextBox();
            buttonHelp_DAA = new Button();
            buttonDone_DAA = new Button();
            groupBoxCondition_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMtrx_DAA).BeginInit();
            groupBoxOutput_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMtrx2_DAA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_DAA
            // 
            groupBoxCondition_DAA.Controls.Add(dataGridViewMtrx_DAA);
            groupBoxCondition_DAA.Controls.Add(textBoxCondition_DAA);
            groupBoxCondition_DAA.Location = new Point(16, 10);
            groupBoxCondition_DAA.Name = "groupBoxCondition_DAA";
            groupBoxCondition_DAA.Size = new Size(471, 405);
            groupBoxCondition_DAA.TabIndex = 0;
            groupBoxCondition_DAA.TabStop = false;
            groupBoxCondition_DAA.Text = "Условие";
            // 
            // dataGridViewMtrx_DAA
            // 
            dataGridViewMtrx_DAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMtrx_DAA.Location = new Point(177, 51);
            dataGridViewMtrx_DAA.Name = "dataGridViewMtrx_DAA";
            dataGridViewMtrx_DAA.RowHeadersVisible = false;
            dataGridViewMtrx_DAA.RowHeadersWidth = 51;
            dataGridViewMtrx_DAA.Size = new Size(284, 244);
            dataGridViewMtrx_DAA.TabIndex = 1;
            // 
            // textBoxCondition_DAA
            // 
            textBoxCondition_DAA.Location = new Point(15, 42);
            textBoxCondition_DAA.Multiline = true;
            textBoxCondition_DAA.Name = "textBoxCondition_DAA";
            textBoxCondition_DAA.ReadOnly = true;
            textBoxCondition_DAA.Size = new Size(156, 329);
            textBoxCondition_DAA.TabIndex = 0;
            textBoxCondition_DAA.Text = "Дан массив 5 на 5 элементов. \r\n\r\nЗаменить четные значения в четвертой строке на 0.";
            // 
            // groupBoxOutput_DAA
            // 
            groupBoxOutput_DAA.Controls.Add(dataGridViewMtrx2_DAA);
            groupBoxOutput_DAA.Controls.Add(textBoxResult_DAA);
            groupBoxOutput_DAA.Location = new Point(522, 12);
            groupBoxOutput_DAA.Name = "groupBoxOutput_DAA";
            groupBoxOutput_DAA.Size = new Size(450, 358);
            groupBoxOutput_DAA.TabIndex = 0;
            groupBoxOutput_DAA.TabStop = false;
            groupBoxOutput_DAA.Text = "Вывод данных";
            // 
            // dataGridViewMtrx2_DAA
            // 
            dataGridViewMtrx2_DAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMtrx2_DAA.Location = new Point(8, 61);
            dataGridViewMtrx2_DAA.Name = "dataGridViewMtrx2_DAA";
            dataGridViewMtrx2_DAA.RowHeadersVisible = false;
            dataGridViewMtrx2_DAA.RowHeadersWidth = 51;
            dataGridViewMtrx2_DAA.Size = new Size(436, 232);
            dataGridViewMtrx2_DAA.TabIndex = 1;
            // 
            // textBoxResult_DAA
            // 
            textBoxResult_DAA.Location = new Point(6, 26);
            textBoxResult_DAA.Name = "textBoxResult_DAA";
            textBoxResult_DAA.ReadOnly = true;
            textBoxResult_DAA.Size = new Size(125, 27);
            textBoxResult_DAA.TabIndex = 0;
            textBoxResult_DAA.Text = "Результат";
            // 
            // buttonHelp_DAA
            // 
            buttonHelp_DAA.Location = new Point(616, 403);
            buttonHelp_DAA.Name = "buttonHelp_DAA";
            buttonHelp_DAA.Size = new Size(94, 29);
            buttonHelp_DAA.TabIndex = 1;
            buttonHelp_DAA.Text = "?";
            buttonHelp_DAA.UseVisualStyleBackColor = true;
            buttonHelp_DAA.Click += buttonHelp_DAA_Click;
            // 
            // buttonDone_DAA
            // 
            buttonDone_DAA.Location = new Point(716, 403);
            buttonDone_DAA.Name = "buttonDone_DAA";
            buttonDone_DAA.Size = new Size(112, 29);
            buttonDone_DAA.TabIndex = 2;
            buttonDone_DAA.Text = "Выполнить";
            buttonDone_DAA.UseVisualStyleBackColor = true;
            buttonDone_DAA.Click += buttonDone_DAA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 450);
            Controls.Add(buttonDone_DAA);
            Controls.Add(buttonHelp_DAA);
            Controls.Add(groupBoxOutput_DAA);
            Controls.Add(groupBoxCondition_DAA);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6";
            Load += FormMain_Load;
            groupBoxCondition_DAA.ResumeLayout(false);
            groupBoxCondition_DAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMtrx_DAA).EndInit();
            groupBoxOutput_DAA.ResumeLayout(false);
            groupBoxOutput_DAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMtrx2_DAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_DAA;
        private DataGridView dataGridViewMtrx_DAA;
        private TextBox textBoxCondition_DAA;
        private GroupBox groupBoxOutput_DAA;
        private DataGridView dataGridViewMtrx2_DAA;
        private TextBox textBoxResult_DAA;
        private Button buttonHelp_DAA;
        private Button buttonDone_DAA;
    }
}
