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
using CommonLibrary.LanguageExtensions;

namespace TimeComboboxApp
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
            IncrementsComboBox.DataSource = Enum.GetValues(typeof(TimeIncrement)).Cast<TimeIncrement>().ToList();

            TimeComboBox1.Increment = TimeIncrement.Quarterly;
            IncrementsComboBox.SelectedIndex = IncrementsComboBox.FindString(TimeComboBox1.Increment.ToString());

            var position = TimeComboBox1.FindString(DateTime.Now.RoundedQuarterly().ToString(Hours.TimeFormat));

            TimeComboBox1.SelectedIndex = (position > -1) ? position : 0;
            IncrementsComboBox.SelectedIndexChanged += OnSelectedIndexChanged;

            textBox1.Text = TimeComboBox1.TimeSpan.Formatted();

        }

        private void OnSelectedIndexChanged(object? sender, EventArgs e)
        {
            string current = TimeComboBox1.TimeSpan.CurrentHour();
            var selectedItem = (TimeIncrement)IncrementsComboBox.SelectedItem;

            TimeComboBox1.Increment = selectedItem;
            TimeComboBox1.SelectedIndex = 0;

            var position = TimeComboBox1.FindString(current);

            TimeComboBox1.SelectedIndex = (position > -1) ? position : 0;
            textBox1.Text = "";
        }

        private void GetTimeButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = TimeComboBox1.TimeSpan.Formatted();
        }
    }
}
