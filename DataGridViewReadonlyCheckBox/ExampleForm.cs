using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataGridViewReadonlyCheckBox
{
    public partial class ExampleForm : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        public ExampleForm()
        {
            InitializeComponent();
            _bindingSource.DataSource = new List<Item>()
            {
                new Item() {Check = false, Name = "Apples", Quantity = 1},
                new Item() {Check = true, Name = "Oranges", Quantity = 0},
            };

            dataGridView1.CellValidating += DataGridView1_CellValidating;
            dataGridView1.DataSource = _bindingSource;

        }
        
        public string NumberCleaner(string value) 
            => System.Text.RegularExpressions.Regex.Replace(value, "[^0-9]", "");

        private void DataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView GridView = dataGridView1;
            DataGridViewCell cell = GridView[e.ColumnIndex, e.RowIndex];

            if (!cell.IsInEditMode) return;

            Control control = GridView.EditingControl;

            switch (GridView.Columns[e.ColumnIndex].Name)
            {
                case nameof(Item.Quantity):
                    control.Text = NumberCleaner(control.Text);
                    break;
            }
        }
        private void ByIndexButton_Click(object sender, EventArgs e)
        {
            int index = (int)numericUpDown1.Value;

            if (index <= _bindingSource.Count -1)
            {
                var item = (Item)_bindingSource[index];
                MessageBox.Show($"{(item.Check ? "Yes" : "No"),-5}{item.Name}{item.Quantity,4}");
            }
            else
            {
                MessageBox.Show($"{index} is out of range");
            }
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current != null)
            {
                var item = (Item)_bindingSource.Current;
                MessageBox.Show($"{(item.Check ? "Yes" : "No"), -5}{item.Name}{item.Quantity,4}");
            }
        }
    }
}
