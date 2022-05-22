using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumbersOnlyTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.KeyPress += TextBox1OnKeyPress;
        }

        private void TextBox1OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == 46 && (sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
            {
                e.Handled = true;
            }
        }

        private void GetValueButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out var value))
            {
                Console.WriteLine((int)value);
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }

        private void NumericUpDownValueButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(specialNumericUpDown1.AsString);
        }
    }
}
