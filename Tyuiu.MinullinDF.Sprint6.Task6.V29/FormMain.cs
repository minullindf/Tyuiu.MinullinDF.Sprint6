using Tyuiu.MinullinDF.Sprint6.Task6.V29.Lib;
namespace Tyuiu.MinullinDF.Sprint6.Task6.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string OpenFilePath;
        DataService ds = new DataService();

        private void buttonOpen_MDF_Click(object sender, EventArgs e)
        {
            openFileDialog_MDF.ShowDialog();
            OpenFilePath = openFileDialog_MDF.FileName;
            textBoxInPut_MDF.Text = File.ReadAllText(OpenFilePath);
            groupBoxOutput_MDF.Text = groupBoxOutput_MDF.Text + " " + openFileDialog_MDF.FileName;
            buttonDone_MDF.Enabled = true;
        }

        private void buttonDone_MDF_Click(object sender, EventArgs e)
        {
            textBoxOutPut_MDF.Text = ds.CollectTextFromFile(OpenFilePath);
        }

        private void buttonHelp_MDF_Click(object sender, EventArgs e)
        {
            FormAbout_MDF formAbout = new FormAbout_MDF();
            formAbout.ShowDialog();
        }
    }
}
