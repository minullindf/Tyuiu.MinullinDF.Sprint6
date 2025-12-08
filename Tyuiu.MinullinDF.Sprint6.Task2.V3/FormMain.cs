using Tyuiu.MinullinDF.Sprint6.Task2.V3.Lib;
namespace Tyuiu.MinullinDF.Sprint6.Task2.V3
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
                int startStep = Convert.ToInt32(textBoxStartValue_MDF.Text);
                int stopStep = Convert.ToInt32(textBoxEndValue_MDF.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chart_MDF.Titles.Add("График функции");
                this.chart_MDF.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart_MDF.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridView_MDF.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chart_MDF.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonInfo_MDF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУБ-25-1 Минуллин Динар Фаатович", "Информация о создателе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void buttonDone_MDF_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_MDF.BackColor = Color.Red;
        }

        private void buttonDone_MDF_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_MDF.BackColor = Color.Green;
        }

        private void buttonDone_MDF_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_MDF.BackColor = Color.Blue;
        }
    }
}
