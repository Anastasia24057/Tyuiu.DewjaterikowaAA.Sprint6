using Tyuiu.DewjaterikowaAA.Sprint6.Task0.V9.Lib;
namespace Tyuiu.DewjaterikowaAA.Sprint6.Task0.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_DAA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_DAA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_DAA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_DAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_DAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка ИИПБ-25-1 Девятерикова Анастасия Андреевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
