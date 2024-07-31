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
using GetControlFormProject.Extensions;

namespace GetControlFormProject
{
    public partial class TabControlForm : Form
    {
        public TabControlForm()
        {
            InitializeComponent();
        }

        private void TraverseButton_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            var tabs = this.TabControlList();

            foreach (TabControl tab in tabs)
            {
                builder.AppendLine(tab.Name);
                foreach (CheckBox box in tab.CheckBoxList())
                {
                    builder.AppendLine($"\t{box.Parent.Name,-20}{box.Name, -20}{box.Checked}");
                }
            }

            Debug.WriteLine(builder);
        }
    }
}
