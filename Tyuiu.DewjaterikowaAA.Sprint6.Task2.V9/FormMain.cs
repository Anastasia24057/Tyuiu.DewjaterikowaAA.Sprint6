using Tyuiu.DewjaterikowaAA.Sprint6.Task2.V9.Lib;
namespace Tyuiu.DewjaterikowaAA.Sprint6.Task2.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonResult_DAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_DAA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_DAA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartResult.Titles.Add("График функции");
                this.chartResult.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartResult.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_DAA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartResult.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_DAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка ИИПБ-25-1 Девятерикова Анастасия Андреевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResult_DAA_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_DAA.BackColor = Color.Red;
        }

        private void buttonResult_DAA_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_DAA.BackColor = Color.Green;
        }

        private void buttonResult_DAA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_DAA.BackColor = Color.Blue;
        }
    }
}
