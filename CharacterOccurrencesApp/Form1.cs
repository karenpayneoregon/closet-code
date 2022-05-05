using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterOccurrencesApp.Classes;

namespace CharacterOccurrencesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetFromTextBoxsTextBox_Click(object sender, EventArgs e)
        {
            ClearListViews();

            List<Item> items = Operations.GetAllItems(textBox1.Text);

            foreach (var item in items.Where(item => char.IsDigit(item.Character)))
            {
                listView1.Items.Add(new ListViewItem(item.ItemArray));
            }

            items = Operations.GetAllItems(textBox2.Text);

            foreach (var item in items.Where(item => char.IsDigit(item.Character)))
            {
                listView2.Items.Add(new ListViewItem(item.ItemArray));
            }
        }

        private void ReadFromFileButton_Click(object sender, EventArgs e)
        {
            ClearListViews();

            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data.txt");
            List<List<Item>> items = Operations.ReadFromFile(fileName);
            
            foreach (var item in items)
            {
                foreach (var item1 in item)
                {
                    listView1.Items.Add(new ListViewItem(item1.ItemArray));
                }

                listView1.Items.Add("");
            }


        }

        private void ClearListViews()
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
        }
    }
}
