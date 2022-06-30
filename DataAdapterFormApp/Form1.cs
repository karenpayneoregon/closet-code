using System;
using System.Windows.Forms;
using DataAdapterFormApp.Classes;

namespace DataAdapterFormApp
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        /// <summary>
        /// Populate the DataTable with zero records
        /// </summary>
        private void OnShown(object sender, EventArgs e)
        {
            var (success, exception) = EmployeeOperations.Load();

            if (success)
            {
                dataGridView1.DataSource = EmployeeOperations.BindingSource;
                dataGridView1.Columns[0].ReadOnly = true;
            }
            else
            {
                SaveChangeButton.Enabled = false;
                MessageBox.Show($@"Failed to load data\n{exception.Message}");
            }

        }

        /// <summary>
        /// Save all changes
        /// </summary>
        private void SaveChangeButton_Click(object sender, EventArgs e)
        {
            var (affected, exception) = EmployeeOperations.SaveChanges();
            if (exception != null)
            {
                MessageBox.Show($@"Save failed\n{exception.Message}");
            }
            else
            {
                MessageBox.Show($@"Affected records {affected}");
            }
        }
    }
}
