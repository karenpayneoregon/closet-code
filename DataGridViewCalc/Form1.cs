using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewCalc
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _bindingSource.DataSource = DataTable();
            dataGridView1.DataSource = _bindingSource;
            dataGridView1.DataError += DataGridView1OnDataError;
        }

        private void DataGridView1OnDataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            Console.WriteLine(e.Exception.Message);
            MessageBox.Show("Wrong type");
        }

        private DataTable DataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Col1", typeof(int));
            dt.Columns.Add("Col2", typeof(int));
            dt.Columns.Add("Total", typeof(int)).Expression = "Col1 + Col2";

            dt.Rows.Add(10, 10);
            dt.Rows.Add(0, 0);
            dt.Rows.Add(30, 50);
            return dt;
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current == null)
            {
                return;
            }

            var row = ((DataRowView)_bindingSource.Current).Row;
            MessageBox.Show($@"Total is {row.Field<int>("Total")}");
        }
    }
}
