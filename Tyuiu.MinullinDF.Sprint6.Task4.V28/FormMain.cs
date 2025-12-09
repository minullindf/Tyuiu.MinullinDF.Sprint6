using Tyuiu.MinullinDF.Sprint6.Task4.V28.Lib;
namespace Tyuiu.MinullinDF.Sprint6.Task4.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonInfo_MDF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУБ-25-1 Минуллин Динар Фаатович", "Информация о создателе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_MDF_Click(object sender, EventArgs e)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
            File.WriteAllText(path, textBoxOutput_MDF.Text);

            DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно! \nоткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
        }

        private void buttonDone_MDF_Click(object sender, EventArgs e)
        {   try
            {
                chart_MDF.Series[0].Points.Clear();
                int startValue = Convert.ToInt32(textBoxStartValue_MDF.Text);
                int endValue = Convert.ToInt32(textBoxEndValue_MDF.Text);

                double[] valueArr = ds.GetMassFunction(startValue, endValue);

                this.chart_MDF.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart_MDF.ChartAreas[0].AxisY.Title = "Ось Y";


                textBoxOutput_MDF.Text = "";

                for (int i = 0; i < valueArr.Length; i++)
                {
                    textBoxOutput_MDF.AppendText(valueArr[i] + Environment.NewLine);
                    this.chart_MDF.Series[0].Points.AddXY(startValue, valueArr[i]);
                    startValue++;
                }
            }
            catch 
            {
                MessageBox.Show("Неверно введены данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
