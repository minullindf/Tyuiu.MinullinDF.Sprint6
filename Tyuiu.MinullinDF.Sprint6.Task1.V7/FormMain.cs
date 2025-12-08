using Tyuiu.MinullinDF.Sprint6.Task1.V7.Lib;
namespace Tyuiu.MinullinDF.Sprint6.Task1.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_MDF_Click(object sender, EventArgs e)
        {
            try
            {
                int sV = Convert.ToInt32(textBoxStartValue_MDF.Text);
                int eV = Convert.ToInt32(textBoxEndValue_MDF.Text);

                string strLine;
                double[] valueArray = ds.GetMassFunction(sV, eV);
                int len = valueArray.Length;

                textBoxOutput_MDF.Text = "";
                textBoxOutput_MDF.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxOutput_MDF.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxOutput_MDF.AppendText("+----------+----------+" + Environment.NewLine);

                foreach (double i in valueArray) 
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}   |" + Environment.NewLine, sV, i);
                    textBoxOutput_MDF.AppendText(strLine);
                    sV++;
                }
                textBoxOutput_MDF.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_MDF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУБ-25-1 Минуллин Динар Фаатович", "Информация о создателе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
