using System.Windows.Forms;
using Tyuiu.GizatullinAP.Sprint6.Task1.V24.Lib;
namespace Tyuiu.GiztullinAP.Sprint6.Task1.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_GAP.Text);
                int stopStep = Convert.ToInt32(textBoxStop_GAP.Text);

                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_GAP.Text = "";
                textBoxResult_GAP.AppendText("+---------+---------+" + Environment.NewLine);
                textBoxResult_GAP.AppendText("|    X    |   f(x)  |" + Environment.NewLine);
                textBoxResult_GAP.AppendText("+---------+---------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,7:d}  | {1, 7:f2} |", startStep, valueArray[i]);
                    textBoxResult_GAP.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_GAP.AppendText("+---------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GAP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИСПб-24-1 Гизатуллин Артём Павлович", "Сообщение");
        }
    }
}
