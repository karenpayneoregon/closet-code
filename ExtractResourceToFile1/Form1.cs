﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtractResourceToFile1.Extensions;
using ExtractResourceToFile1.Properties;

namespace ExtractResourceToFile1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ColorCop is a exe resource
        /// http://colorcop.net/
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExtractButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(FileNameTextBox.Text))
            {
                Resources.ColorCop.FileSave(FileNameTextBox.Text);
                Process.Start(FileNameTextBox.Text);
            }
           
        }
    }
}
