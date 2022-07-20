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
using WorkingWithSingletons.Classes;

namespace AppSettingsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void IndexerButton_Click(object sender, EventArgs e)
        {
            AppSettings.Instance.PValue[0] = "A";
            AppSettings.Instance.PValue[1] = "B";
            AppSettings.Instance.PValue[2] = "C";
            AppSettings.Instance.PValue[3] = "D";
            AppSettings.Instance.PValue[4] = "E";

            Debug.WriteLine(AppSettings.Instance.GetPValue());
            for (int index = 0; index < 9; index++)
            {
                AppSettings.Instance.Increment();
                Debug.WriteLine(AppSettings.Instance.GetPValue());
            }

            Debug.WriteLine("");

            for (int index = 9 - 1; index >= 0; index--)
            {
                AppSettings.Instance.Decrement();
                Debug.WriteLine(AppSettings.Instance.GetPValue());
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = Math.Clamp(4, 1, 3);
            Debug.WriteLine(result);

            result = Math.Clamp(2, 1, 3);
            Debug.WriteLine(result);
        }
    }
}
