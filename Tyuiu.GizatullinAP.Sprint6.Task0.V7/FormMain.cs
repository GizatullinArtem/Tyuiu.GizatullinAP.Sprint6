using Tyuiu.GizatullinAP.Sprint6.Task0.V7.Lib;
namespace Tyuiu.GizatullinAP.Sprint6.Task0.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button2_GAP_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBox2_GAP.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBox1_GAP)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_GAP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void button1_GAP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИСПб-24-1 Гизатуллин Артём Павлович", "Сообщение");
        }
    }
}
