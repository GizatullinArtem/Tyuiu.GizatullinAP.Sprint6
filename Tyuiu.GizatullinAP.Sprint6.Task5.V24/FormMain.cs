using Tyuiu.GizatullinAP.Sprint6.Task5.V24.Lib;
namespace Tyuiu.GizatullinAP.Sprint6.Task5.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService dataService = new DataService();
        //string path = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
        string path = Path.Combine(@"C:\DataSprint6\InPutDataFileTask5V24.txt");

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridView_GAP.ColumnCount = 2;
            dataGridView_GAP.Columns[0].Width = 20;
            dataGridView_GAP.Columns[1].Width = 50;

            chart_GAP.ChartAreas[0].AxisX.Title = "ось X";
            chart_GAP.ChartAreas[0].AxisY.Title = "ось Y";
            chart_GAP.Series[0].Points.Clear();

            double[] valueArray = new double[dataService.Lenght];

            valueArray = dataService.LoadFromDataFile(path);

            for (int i = 0; i < valueArray.Length; i++)
            {
                dataGridView_GAP.Rows.Add(Convert.ToString(i), Convert.ToString(valueArray[i]));
                chart_GAP.Series[0].Points.AddXY(i, valueArray[i]);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент ИСПб-24-1 Гизатуллин Артём Павлович","Сообщение", MessageBoxButtons.OK);
        }

        private void buttonOpen_Click(Object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

    }
}