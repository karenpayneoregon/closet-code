
using System.ComponentModel;
using System.Diagnostics;
using ForumQuestion1.Classes;
using ForumQuestion1.Models;

namespace ForumQuestion1
{
    public partial class Form1 : Form
    {
        private BindingList<DataContainer> _bindingList1;
        private BindingSource _bindingSource1 = new ();

        private BindingList<DataContainer> _bindingList2;
        private BindingSource _bindingSource2 = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateJsonFileButton_Click(object sender, EventArgs e)
        {
            Mocked.Create();
        }

        private void ReadJustCreatedFileButton_Click(object sender, EventArgs e)
        {

            try
            {
                listBox1.DataSource = null;
                _bindingList1 = new BindingList<DataContainer>(Operations.ReadFile());
                _bindingSource1.DataSource = _bindingList1;
                listBox1.DataSource = _bindingSource1;
                listBox1.SelectedIndex = _bindingList1.Count - 1;


                comboBox1.DataSource = null;
                _bindingList2 = new BindingList<DataContainer>(Operations.ReadFile());
                _bindingSource2.DataSource = _bindingList1;
                comboBox1.DataSource = _bindingSource2;
            }
            catch
            {
                MessageBox.Show(@"Must create first");
            }
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            if ((_bindingSource1.Count == 0))
            {
                return;
            }

            // consider CompanyName coming from a TextBox
            var dataContainer = new DataContainer() { CompanyName = "Amazon" };
            Operations.Add(dataContainer);
            _bindingList1.Add(dataContainer);
            listBox1.SelectedIndex = _bindingList1.Count - 1;
        }

        private void GetSelectedButton_Click(object sender, EventArgs e)
        {
            if (_bindingSource1.Count >0)
            {
                DataContainer container = _bindingList1[_bindingSource1.Position];
                MessageBox.Show($"{container}");
            }
            else
            {
                MessageBox.Show("None");
            }
        }

        private void TryAddNewButton_Click(object sender, EventArgs e)
        {
            if ((_bindingSource1.Count == 0))
            {
                return;
            }

            if (!string.IsNullOrWhiteSpace(CompanyNameTextBox.Text))
            {
                if (Operations.List.FirstOrDefault(x => x.CompanyName.Equals(CompanyNameTextBox.Text, StringComparison.OrdinalIgnoreCase)) == null)
                {
                    var dataContainer = new DataContainer() { CompanyName = CompanyNameTextBox.Text };
                    Operations.Add(dataContainer);
                    _bindingList1.Add(dataContainer);
                    listBox1.SelectedIndex = _bindingList1.Count - 1;

                    _bindingList2.Add(dataContainer);
                }
                else
                {
                    MessageBox.Show($"Company {CompanyNameTextBox.Text} already exists");
                }
            }
            else
            {
                MessageBox.Show("Enter a company name");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Operations.Save();
        }
    }
}