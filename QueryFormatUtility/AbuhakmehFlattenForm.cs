using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QueryFormatUtility.Extensions.StringExtensions;

namespace QueryFormatUtility
{
    public partial class AbuhakmehFlattenForm : Form
    {
        public AbuhakmehFlattenForm()
        {
            InitializeComponent();

            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            ResultsTextBox.Text = Sql(OriginalTextBox.Text);
            OriginalTextBox.Select(0,0);
        }
    }
}
