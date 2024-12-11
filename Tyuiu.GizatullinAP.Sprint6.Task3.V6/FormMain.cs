using Tyuiu.GizatullinAP.Sprint6.Task3.V6.Lib;
namespace Tyuiu.GizatullinAP.Sprint6.Task3.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService();
        int[,] mtrx = new int[,] { {-2,-10,-8,11,1 },
                           {-15,-9,-4,-15,18 },
                           {-15,12,7,6,9 },
                           {-14,-10,10,18,-5 },
                           {-1, 7,-19,-19,-4 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetLength(0);
            int cols = mtrx.GetLength(1);
            dataGridViewMatrix_GAP.ColumnCount = cols;
            dataGridViewMatrix_GAP.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrix_GAP.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix_GAP.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_GAP_Click(object sender, EventArgs e)
        {
            int rows = mtrx.GetLength(0);
            int cols = mtrx.GetLength(1);
            dataGridViewResult_GAP.ColumnCount = cols;
            dataGridViewResult_GAP.RowCount = rows;
            int[,] res = ds.Calculate(mtrx);

            for (int i = 0; i < cols; i++)
            {
                dataGridViewResult_GAP.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewResult_GAP.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void buttonHelp_GAP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 Выполнил студент ИСПб-24-1 Гизатуллин Артём Павлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}