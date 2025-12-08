using Tyuiu.MinullinDF.Sprint6.Task3.V2.Lib;
namespace Tyuiu.MinullinDF.Sprint6.Task3.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = { {-12, -4, -20, 5, -5 },
                        { 2, 15, 1, -20, 7 },
                        { 15, -15, 2, 11, 5 },
                        { -19, -9, 16, 0, 1 },
                        { 17, 16, 5, 12, -8 }};

        private void buttonDone_MDF_Click(object sender, EventArgs e)
        {
            int[,] matrX = ds.Calculate(matrix);
            int rows = matrX.GetUpperBound(0) + 1;
            int columns = matrX.Length / rows;
            int count = 0;
            
            dataGridView_MDF.ColumnCount = columns;
            dataGridView_MDF.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridView_MDF.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrX[i, j] == 0) { count++; }
                    dataGridView_MDF.Rows[i].Cells[j].Value = Convert.ToString(matrX[i, j]);
                }
            }
            textBoxResult_MDF.Text = count.ToString();

        }

        private void buttonQuestion_MDF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУБ-25-1 Минуллин Динар Фаатович", "Информация о создателе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_MDF_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridView_MDF.ColumnCount = columns;
            dataGridView_MDF.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridView_MDF.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView_MDF.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
    }
}
