using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterOccurrencesApp.Classes;

namespace CharacterOccurrencesApp
{
    public partial class ConverterForm : Form
    {
        public ConverterForm()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>() { "a", "2", null, "4" };
            var result1 = list.ToIntegerArray();

            Debug.WriteLine("Only output ints");
            foreach (var item in result1)
            {
                Debug.WriteLine(item);
            }

            Debug.WriteLine("When not an int default to 0");
            var result2 = list.ToIntegerPreserveArray();
            foreach (var item in result2)
            {
                Debug.WriteLine(item);
            }

            Debug.WriteLine("Get indices of non-int elements");
            var result3 = list.GetNonIntegerIndexes();
            foreach (var item in result3)
            {
                Debug.WriteLine(item);
            }
        }
    }
}
