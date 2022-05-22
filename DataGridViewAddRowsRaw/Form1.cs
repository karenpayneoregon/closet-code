using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 4;

            for (int index = 0; index < dataGridView1.Columns.Count; index++)
            {
                dataGridView1.Columns[index].HeaderText = $"Column {index +1}";
            }

            dataGridView1.Rows.Add(1, 2, 3, 4);

        }

        private void AddRowsButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count == 1)
            {
                dataGridView1.Rows.Add(1, 2, 3, 4);
            }

            for (int index = 0; index < 4; index++)
            {
                var row = dataGridView1.Rows.Cast<DataGridViewRow>()
                    .LastOrDefault(gridRow => !gridRow.IsNewRow);

                if (int.TryParse(row.Cells[3].Value.ToString(), out var lastValue))
                {
                    lastValue  += 1;

                    dataGridView1.Rows.Add(
                        lastValue,
                        lastValue += 1,
                        lastValue += 1,
                        lastValue += 1);
                }

            }

        }
    }
}
