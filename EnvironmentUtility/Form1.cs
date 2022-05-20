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
using EnvironmentUtility.Classes;

namespace EnvironmentUtility
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
            EnvironmentComboBox.DataSource = new List<string>() { "DEVELOPMENT", "TEST", "PRODUCTION" };
            var index = EnvironmentComboBox.FindString(Environment.GetEnvironmentVariable("OED_ENVIRONMENT"));
            if (index > -1)
            {
                EnvironmentComboBox.SelectedIndex = index;
            }
        }

        private async void SetButton_Click(object sender, EventArgs e)
        {
            await Operations.SetOedEnvironment(EnvironmentComboBox.Text);
        }
    }
}
