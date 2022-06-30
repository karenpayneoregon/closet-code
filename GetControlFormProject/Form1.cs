using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            listBox1.DataSource = this.TextBoxList().Select(x => new TextBoxItem(x.Name, x.Text)).ToList();
        }
    }
}
