using Tyuiu.DewjaterikowaAA.Sprint6.Task3.V28.Lib;
namespace Tyuiu.DewjaterikowaAA.Sprint6.Task3.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { { -9, 8, 9, 16, -18 },
                                            { -13, -11, -20, -15, 9 },
                                            { 18, 13, -12, -15, -11 },
                                            { 10, -2, 19, -4, -10 },
                                            { 6, -20, -4, 13, -14 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMtrx_DAA.ColumnCount = columns;
            dataGridViewMtrx_DAA.RowCount = rows;
            dataGridViewMtrx2_DAA.ColumnCount = columns;
            dataGridViewMtrx2_DAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMtrx_DAA.Columns[i].Width = 50;
                dataGridViewMtrx_DAA.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMtrx_DAA.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonDone_DAA_Click(object sender, EventArgs e)
        {
            int[,] result_matrix = ds.Calculate(matrix);

            int rows = result_matrix.GetUpperBound(0) + 1;
            int columns = result_matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMtrx2_DAA.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonHelp_DAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка ИИПБ-25-1 Девятерикова Анастасия Андреевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
