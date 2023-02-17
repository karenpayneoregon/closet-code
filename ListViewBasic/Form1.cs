using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace ListViewBasic
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, string> _dictionary = 
            new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            listView1.MouseDoubleClick += ListView1_MouseDoubleClick;

            _dictionary.Add("A1", "111");
            _dictionary.Add("B1", "222");
            _dictionary.Add("C1", "333");

            foreach (var item in _dictionary)
            {
                listView1.Items.Add(
                    new ListViewItem(new[] { item.Key, item.Value })
                    {
                        Tag = item.Key
                    });
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.Items[0].Selected = true;
            ActiveControl = listView1;
        }

        private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                return;
            }

            MessageBox.Show($"Key {listView1.SelectedItems[0].Text} Value {listView1.SelectedItems[0].SubItems[1].Text}");
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            if (!_dictionary.ContainsKey(KeyTextBox.Text))
            {
                listView1.Items.Add(
                    new ListViewItem(new []{KeyTextBox.Text, ValueTextBox.Text})
                    {
                        Tag = KeyTextBox.Text
                    });

                _dictionary.Add(KeyTextBox.Text, ValueTextBox.Text);

                KeyTextBox.Text = "";
                ValueTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("dup key");
            }
        }

        private void IterateButton_Click(object sender, System.EventArgs e)
        {
            var items = listView1.SelectedItems;
            if (items.Count > 0)
            {
                foreach (ListViewItem item in items)
                {
                    Console.WriteLine($@"{item.Text,-10}{item.SubItems[1].Text}");
                }
            }
        }
    }
}
