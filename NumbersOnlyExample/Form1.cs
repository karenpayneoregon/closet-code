using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumbersOnlyExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void CountButton_Click(object sender, EventArgs e)
        {
            int count = CountNumericUpDown.AsInteger;
            for (int index = 0; index < count; index++)
            {
                Console.WriteLine(index);
            }
        }
    }
}
