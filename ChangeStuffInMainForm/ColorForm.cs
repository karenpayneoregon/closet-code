using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeStuffInMainForm
{
    public partial class ColorForm : Form
    {

        public Color SelectedColor { get; protected set; }
        public ColorForm()
        {
            InitializeComponent();
            colorGrid1.Click += ColorGrid1OnClick;
        }

        private void ColorGrid1OnClick(object sender, EventArgs e)
        {
            SelectedColor = colorGrid1.Color;
        }
    }
}
