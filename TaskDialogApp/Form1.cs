using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsLibrary.Classes;

namespace TaskDialogApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void QuestionButton_Click(object sender, EventArgs e)
        {
            if (Dialogs.Question(this, "Question", "Do you like tea?", "Yep", "Nope", DialogResult.No))
            {
                Dialogs.Information(this,"Yes", "Woohoo");
            }
            else
            {
                Dialogs.Information(this, "Nope", "Dang");
            }
        }
    }
}
