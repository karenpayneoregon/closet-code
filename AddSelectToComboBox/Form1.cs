using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AddSelectToComboBox.Classes;
using AddSelectToComboBox.Models;

namespace AddSelectToComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MonthsComboBox.DataSource = Operations.Months();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {

            var month = ((MonthItem)MonthsComboBox.SelectedItem);
            if (month.Index == -1)
            {
                MessageBox.Show("Make a selection");
            }
            else
            {
                MessageBox.Show($"{month.Index,-3}{month.Name}");
            }
        }
    }
}
