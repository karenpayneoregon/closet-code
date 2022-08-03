using System;
using System.Data;
using System.Windows.Forms;

namespace DataGridViewExportTextFile
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            Shown += Form2_Shown;
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.AddRange(new []
            {
                new DataColumn("c0"), 
                new DataColumn("c1"), 
                new DataColumn("c2"), 
                new DataColumn("c3")
            });

            dt.Rows.Add("", "", "", "");
            dt.Rows.Add("", "", "", "");
            dt.Rows.Add("", "", "", "");
            dt.Rows.Add("", "", "", "");

            dataGridView1.DataSource = dt;

            dataGridView1[0, 0].Selected = false;
            dataGridView1[2, 3].Selected = true;
            dataGridView1[2, 2].Selected = true;

            dt.Rows[2].SetField("c2","Selected");
            dt.Rows[3].SetField("c2","Selected");
        }
    }
}
