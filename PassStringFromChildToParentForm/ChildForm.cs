using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;



namespace PassStringFromChildToParentForm
{
    public partial class ChildForm : Form
    {
        public delegate void OnPassMonths(string text);
        public event OnPassMonths PassMonths;

        public ChildForm()
        {
            InitializeComponent();
            listBox1.DataSource = System.Globalization
                .DateTimeFormatInfo.CurrentInfo
                .MonthNames.Take(12)
                .ToList();
        }

        private void PassDataButton_Click(object sender, EventArgs e)
        {
            foreach (var monthName in (List<string>)listBox1.DataSource)
            {
                PassMonths?.Invoke(monthName);
            }
        }
    }
}
