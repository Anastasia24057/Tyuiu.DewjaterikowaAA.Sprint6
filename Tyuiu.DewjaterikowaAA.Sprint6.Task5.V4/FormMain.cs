using Tyuiu.DewjaterikowaAA.Sprint6.Task5.V4.Lib;
namespace Tyuiu.DewjaterikowaAA.Sprint6.Task5.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint5\InPutDataFileTask5V4.txt";

        private void buttonDone_DAA_Click(object sender, EventArgs e)
        {
            dataGridViewNums_DAA.ColumnCount = 2;
            dataGridViewNums_DAA.Columns[0].Width = 20;
            dataGridViewNums_DAA.Columns[1].Width = 50;

            this.chartDiag_DAA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_DAA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_DAA.Series[0].Points.Clear();

            double[] numMass = new double[ds.len];

            numMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewNums_DAA.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartDiag_DAA.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void buttonOpenFile_DAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_DAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка ИИПБ-25-1 Девятерикова Анастасия Андреевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
