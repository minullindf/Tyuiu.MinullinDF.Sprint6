using Tyuiu.MinullinDF.Sprint6.Task5.V12.Lib;
namespace Tyuiu.MinullinDF.Sprint6.Task5.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"D:\TYUIU\Tyuiu.MinullinDF.Sprint6\Tyuiu.MinullinDF.Sprint6.Task5.V12\bin\Debug\InPutDataFileTask5V12.txt";

        private void buttonDone_MDF_Click(object sender, EventArgs e)
        {
            dataGridViewResult_MDF.ColumnCount = 2;
            dataGridViewResult_MDF.Columns[0].Width = 20;
            dataGridViewResult_MDF.Columns[1].Width = 50;

            this.chartFunction_MDF.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartFunction_MDF.ChartAreas[0].AxisX.Title = "Ось Y";

            chartFunction_MDF.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_MDF.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_MDF.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpenF_MDF_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_MDF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУБ-25-1 Минуллин Динар Фаатович", "Информация о создателе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
