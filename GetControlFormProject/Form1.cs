using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetControlFormProject.Classes;
using GetControlFormProject.Extensions;

namespace GetControlFormProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<TextBoxItem> textBoxes = this.TextBoxList()
                .Select(textBox => new TextBoxItem(textBox.Name, textBox.Text))
                .OrderBy(textBox => Regex.Match(textBox.Name, @"\d+").Value, 
                    new SemiNumericComparer())
                .ToList();
            listBox1.DataSource = textBoxes;
        }

        private List<TextBox> _textBoxes;
        private void GetAllButtons_Click(object sender, EventArgs e)
        {
            _textBoxes = this.TextBoxList();
        }
    }
}
