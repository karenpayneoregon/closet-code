using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GetControlFormProject.Classes;
using GetControlFormProject.Extensions;

namespace GetControlFormProject
{
    public partial class Form1 : Form
    {
        private List<TextBox> _textBoxes;
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            _textBoxes = this.TextBoxList();
            var companies = BogusOperations.Companies();

            for (int index = 0; index < _textBoxes.Count; index++)
            {
                _textBoxes[index].Text = companies[index].Name;
            }
        }

        private void ToListBoxButton_Click(object sender, EventArgs e)
        {

            List<TextBoxItem> textBoxes = this.TextBoxList()
                .Select(textBox => new TextBoxItem(textBox.Name, textBox.Text))
                .OrderBy(textBox => textBox.Name.DigitsOnly(), 
                    new SemiNumericComparer())
                .ToList();

            listBox1.DataSource = textBoxes;
        }

        

    }
}
