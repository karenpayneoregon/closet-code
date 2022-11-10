
using System.ComponentModel;
using System.Diagnostics;
using ForumQuestion1.Classes;
using ForumQuestion1.Models;

namespace ForumQuestion1
{
    public partial class Form1 : Form
    {
        private BindingList<DataContainer> _bindingList;
        private BindingSource _bindingSource = new ();
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
                _bindingList = new BindingList<DataContainer>(Operations.ReadFile());
                _bindingSource.DataSource = _bindingList;
                listBox1.DataSource = _bindingSource;
                listBox1.SelectedIndex = _bindingList.Count - 1;
            }
            catch
            {
                MessageBox.Show(@"Must create first");
            }
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            if ((_bindingSource.Count == 0))
            {
                return;
            }

            // consider CompanyName coming from a TextBox
            var dataContainer = new DataContainer() { CompanyName = "Amazon" };
            Operations.Add(dataContainer);
            _bindingList.Add(dataContainer);
            listBox1.SelectedIndex = _bindingList.Count - 1;
        }

        private void GetSelectedButton_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Count >0)
            {
                DataContainer container = _bindingList[_bindingSource.Position];
                MessageBox.Show($"{container}");
            }
            else
            {
                MessageBox.Show("None");
            }
        }

        private void TryAddNewButton_Click(object sender, EventArgs e)
        {
            if ((_bindingSource.Count == 0))
            {
                return;
            }

            if (!string.IsNullOrWhiteSpace(CompanyNameTextBox.Text))
            {
                if (Operations.List.FirstOrDefault(x => x.CompanyName.Equals(CompanyNameTextBox.Text, StringComparison.OrdinalIgnoreCase)) == null)
                {
                    var dataContainer = new DataContainer() { CompanyName = CompanyNameTextBox.Text };
                    Operations.Add(dataContainer);
                    _bindingList.Add(dataContainer);
                    listBox1.SelectedIndex = _bindingList.Count - 1;
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