using System;
using System.Linq;
using System.Windows.Forms;

namespace PassStringFromChildToParentForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowChildForm_Click(object sender, EventArgs e)
        {
            ChildForm childForm = new ChildForm();

            childForm.PassMonths += OnPassMonths;

            try
            {
                childForm.ShowDialog();
            }
            finally
            {
                childForm.Dispose();
            }
        }

        private void OnPassMonths(string month)
        {
            if (dataGridView1.MonthNotExists(month))
            {
                dataGridView1.Rows.Add(month);
            }
        }
    }

    public static class DataGridViewExtensions
    {
        // in this case the cell is assumed to be 0, change if not 0
        public static bool MonthNotExists(this DataGridView dgv, string month) => 
            dgv.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(row => row.Cells[0].Value.ToString()
                    .Equals(month)) == null;
    }
}
