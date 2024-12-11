using Tyuiu.GizatullinAP.Sprint6.Task7.V28.Lib;
using System.ComponentModel;

namespace Tyuiu.GizatullinAP.Sprint6.Task7.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_GAP.Filter = "Значения, разделенные запятыми(.csv)|.csv|Все файлы(.)|.";
            saveFileDialogMatrix_GAP.Filter = "Значения, разделенные запятыми(.csv)|.csv|Все файлы(.)|.";
        }

        static int rows;
        static int columns;

        static string openFilePath;
        DataService ds = new DataService();

        public int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void groupBoxCondition_GAP_Enter(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void panelOutPut_GAP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOpenFile_GAP_Click(object sender, EventArgs e)
        {
            openFileDialog_GAP.ShowDialog();
            openFilePath = openFileDialog_GAP.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);
            dataGridViewIn_GAP.ColumnCount = columns;
            dataGridViewIn_GAP.RowCount = rows;
            dataGridViewOut_GAP.ColumnCount = columns;
            dataGridViewOut_GAP.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_GAP.Columns[i].Width = 25;
                dataGridViewOut_GAP.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_GAP.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_GAP.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_GAP.ColumnCount = 50;
            dataGridViewOut_GAP.ColumnCount = 50;

            dataGridViewIn_GAP.RowCount = 50;
            dataGridViewOut_GAP.RowCount = 50;

            panelInPut_GAP.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_GAP.Columns[i].Width = 25;
                dataGridViewOut_GAP.Columns[i].Width = 25;
            }
        }

        private void buttonDone_GAP_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_GAP.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile_GAP.Enabled = true;
        }

        private void buttonSaveFile_GAP_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_GAP.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_GAP.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_GAP.ShowDialog();

            string path = saveFileDialogMatrix_GAP.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_GAP.RowCount;
            int columns = dataGridViewOut_GAP.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_GAP.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_GAP.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void openFileDialog_GAP_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonInfo_GAP_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void label1_GAP_Click(object sender, EventArgs e)
        {

        }
        private void label2_GAP_Click(object sender, EventArgs e)
        {

        }
    }
}
