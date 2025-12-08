using Tyuiu.DewjaterikowaAA.Sprint6.Task6.V18.Lib; 
namespace Tyuiu.DewjaterikowaAA.Sprint6.Task6.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonDone_DAA_Click(object sender, EventArgs e)
        {
            textBoxResult_DAA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_DAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_DAA_Click(object sender, EventArgs e)
        {
            openFileDialog_DAA.ShowDialog();
            openFilePath = openFileDialog_DAA.FileName;
            textBoxInput_DAA.Text = File.ReadAllText(openFilePath);
            groupBoxIn_DAA.Text = groupBoxIn_DAA.Text + " " + openFileDialog_DAA.FileName;
            buttonDone_DAA.Enabled = true;
        }

    }
}
