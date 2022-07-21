using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridViewExportTextFile.Classes;
using DataGridViewExportTextFile.Extensions;

namespace DataGridViewExportTextFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = BogusOperations.People();
            dataGridView1.FixHeaders();
            dataGridView1.ExpandColumns();
            ResizeEnd += OnResizeEnd;
        }

        private void OnResizeEnd(object sender, EventArgs e)
        {
            Console.WriteLine("done");
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            dataGridView1.ExportRows("data1.csv");
        }
    }
}
