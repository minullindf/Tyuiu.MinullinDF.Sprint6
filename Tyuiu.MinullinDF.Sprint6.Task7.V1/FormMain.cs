using Tyuiu.MinullinDF.Sprint6.Task7.V1.Lib;
namespace Tyuiu.MinullinDF.Sprint6.Task7.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_MDF.Filter = "Значения, разделенные запятыми(* .csv)|*.csv|Все фалы(*.*)|*.*";
            saveFileDialogMatrix_MDF.Filter = "Значения, разделенные запятыми(* .csv)|*.csv|Все фалы(*.*)|*.*";
        }
        static string OpenFilePath;
        DataService ds = new DataService();
        static int rows;
        static int columns;

        private void buttonSave_MDF_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_MDF.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_MDF.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_MDF.ShowDialog();

            string path = saveFileDialogMatrix_MDF.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_MDF.RowCount;
            int columns = dataGridViewOutPut_MDF.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_MDF.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_MDF.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonDone_MDF_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(OpenFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPut_MDF.Rows[i].Cells[j].Value = arrayValues[i, j];
                }


            }
            dataGridViewOutPut_MDF.Enabled = true;
        }

        public static int[,] LoadFromFileDta(string FilePath)
        {
            string fileDta = File.ReadAllText(FilePath);
            fileDta = fileDta.Replace('\n', '\r');
            string[] lines = fileDta.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }

        private void buttonOpen_MDF_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MDF.ShowDialog();
            OpenFilePath = openFileDialogTask_MDF.FileName;

            int[,] arrayValues = LoadFromFileDta(OpenFilePath);
            dataGridViewIn_MDF.ColumnCount = columns;
            dataGridViewIn_MDF.RowCount = rows;
            dataGridViewOutPut_MDF.ColumnCount = columns;
            dataGridViewOutPut_MDF.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_MDF.Columns[i].Width = 25;
                dataGridViewOutPut_MDF.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewIn_MDF.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            arrayValues = ds.GetMatrix(OpenFilePath);
            buttonDone_MDF.Enabled = true;

        }

        private void buttonHelp_MDF_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_MDF.ColumnCount = 50;
            dataGridViewOutPut_MDF.ColumnCount = 50;
            dataGridViewIn_MDF.RowCount = 50;
            dataGridViewOutPut_MDF.RowCount = 50;
            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_MDF.Columns[i].Width = 25;
                dataGridViewOutPut_MDF.Columns[i].Width = 25;
            }
        }
    }
}
