using static System.Array;

namespace SendToMainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenChildFormButton_Click(object sender, EventArgs e)
        {
            ChildForm childForm = new() { Owner = this };

            childForm.PassData += ChildFormOnPassData;
            childForm.Show(this);
            childForm.Top = Top;
            childForm.Left = Left +  Width + 10;
        }

        private void ChildFormOnPassData(int[] data)
        {
            listBox1.Items.AddRange(ConvertAll(data, x => x.ToString("D2")));
        }
    }
}