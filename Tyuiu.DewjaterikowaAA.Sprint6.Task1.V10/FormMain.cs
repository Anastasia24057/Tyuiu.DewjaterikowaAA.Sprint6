using Tyuiu.DewjaterikowaAA.Sprint6.Task1.V10.Lib;
namespace Tyuiu.DewjaterikowaAA.Sprint6.Task1.V10
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
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_DAA.Text = "";
                textBoxResult_DAA.AppendText("+--------+--------+" + Environment.NewLine);
                textBoxResult_DAA.AppendText("+     x     |    f(x)   +" + Environment.NewLine);
                textBoxResult_DAA.AppendText("+--------+--------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,7:d}     |  {1,7:f2}   | ", startStep, valueArray[i]);
                    textBoxResult_DAA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_DAA.AppendText("+--------+--------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_DAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка ИИПБ-25-1 Девятерикова Анастасия Андреевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
