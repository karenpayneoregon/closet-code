using System;
using System.Windows.Forms;

namespace YieldReadFileFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void YieldButton_Click(object sender, EventArgs e)
        {
            foreach (var item in FileOperations.ReadYield("TextFile1.txt"))
            {
                listBox1.Items.Add(item);
            }
        }

        private void ExpressionButton_Click(object sender, EventArgs e)
        {
            listBox2.DataSource = FileOperations.Read("TextFile1.txt");
        }
    }
}
