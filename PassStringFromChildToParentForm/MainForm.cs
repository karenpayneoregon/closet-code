using System;
using System.Windows.Forms;

namespace PassStringFromChildToParentForm
{
    public partial class MainForm : Form
    {
        public delegate void OnUpdate(string text);
        public event OnUpdate UpdateData;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowChildForm_Click(object sender, EventArgs e)
        {
            ChildForm childForm = new ChildForm() {Owner = this};
   
            childForm.PassMonths += OnPassMonths;

            childForm.Show(this);
            
        }

        private void OnPassMonths(string month)
        {
            if (dataGridView1.MonthNotExists(month))
            {
                dataGridView1.Rows.Add(month);
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            
        }
    }

    public class DataOperations
    {
        public delegate void OnUpdate(string text);
        public event OnUpdate UpdateData;
    }
}
