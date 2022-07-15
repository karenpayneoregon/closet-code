using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsLibrary.LanguageExtensions;

namespace CloneImageForPictureBox
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
            pbImage1.LoadClone(Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "Images", "DeleteCode.png"), true);
            pbImage2.LoadClone(Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "Images", "oops.png"), false);

            DeleteCheckBox.Checked = File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "DeleteCode.png"));
            OopsCheckBox.Checked = File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "oops.png"));

        }
    }
}
