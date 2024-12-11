using Tyuiu.GizatullinAP.Sprint6.Task6.V29.Lib;
namespace Tyuiu.GizatullinAP.Sprint6.Task6.V29
{
    public partial class Form1 : Form
    {
        
        DataService ds = new DataService();
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_GAP_Click(object sender, EventArgs e)
        {
            textBoxOutput_GAP.Text = ds.CollectTextFromFile(path);
        }

        private void buttonLoad_GAP_Click(object sender, EventArgs e)
        {
            openFileDialog_GAP.ShowDialog();
            path = openFileDialog_GAP.FileName;
            textBoxInput_GAP.Text = File.ReadAllText(path);
            groupBoxInput_GAP.Text = groupBoxInput_GAP.Text + " " + path;
            buttonStart_GAP.Enabled = true;
        }

        private void buttonHelp_GAP_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        private void textBoxOutput_GAP_TextChanged(object sender, EventArgs e)
        {

        }

    }
}