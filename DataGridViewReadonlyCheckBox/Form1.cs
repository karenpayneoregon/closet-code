using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridViewReadonlyCheckBox.Classes;

namespace DataGridViewReadonlyCheckBox
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            bindingSource.DataSource = Operations.Contacts();
            dataGridView1.RowPostPaint += DataGridView1_RowPostPaint;
            dataGridView1.DataSource = bindingSource;
            dataGridView1.Columns[0].HeaderText = "";
            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[1].HeaderText = "Contact";
            dataGridView1.CurrentCell = dataGridView1[1, 0];


        }

        private void DataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var value = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[0];

            if (value != "Germany" || cell.ReadOnly) return;
            DataGridViewCheckBoxCell chkCell = cell as DataGridViewCheckBoxCell;
            chkCell.Value = false;
            chkCell.FlatStyle = FlatStyle.Flat;
            chkCell.Style.ForeColor = Color.DarkGray;
            cell.ReadOnly = true;
        }


    }
}
