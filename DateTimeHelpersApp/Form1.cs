using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLibrary.Classes;

namespace DateTimeHelpersApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            listBox1.DataSource = DateTimeHelpers.MonthNames();
            listBox2.DataSource = DateTimeHelpers.RussianMonthNames();
            TimeOfDayLabel.Text = $@"Time of day greeting '{DateTimeHelpers.TimeOfDay()}'";
        }
    }
}
