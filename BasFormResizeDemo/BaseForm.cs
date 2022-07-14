using System;
using System.Windows.Forms;
using BaseFormResizeDemo.Extensions;

namespace BaseFormResizeDemo
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            Resize += OnResize;
        }

        private void OnResize(object sender, EventArgs e)
        {
            var controls = this.Descendants<Control>();
            foreach (var control in controls)
            {
                Console.WriteLine($"{control.Parent.Name}.{control.Name}");
            }
        }
    }
}
