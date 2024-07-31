using static System.Array;

namespace SendToMainForm
{
    public partial class MainForm : Form
    {
        private ChildForm childForm = new() ;
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenChildFormButton_Click(object sender, EventArgs e)
        {
            childForm.Owner = this;

            childForm.PassData += ChildFormOnPassData;
            childForm.Show(this);
            childForm.Top = Top;
            childForm.Left = Left +  Width + 10;
        }

        private void ChildFormOnPassData(int[] data)
        {
            listBox1.Items.AddRange(ConvertAll(data, x => x.ToString("D2")));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = childForm.textBox1.Text;
        }
    }
}