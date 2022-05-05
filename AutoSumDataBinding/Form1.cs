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
using AutoSumDataBinding.Classes;
using static AutoSumDataBinding.Classes.ControlEvents;

namespace AutoSumDataBinding
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.KeyPress += TextBoxOnKeyPress;
            textBox2.KeyPress += TextBoxOnKeyPress;

            _bindingSource.DataSource = new List<Item>()
            {
                new () {Value1 = 12, Value2 = 4}
            };

            textBox1.DataBindings.Add("Text", _bindingSource, nameof(Item.Value1));

            textBox2.DataBindings.Add("Text", _bindingSource, nameof(Item.Value2));

            var binding = new Binding("Text", _bindingSource, nameof(Item.Total));
            binding.Format += Binding_Format;

            TotalLabel.DataBindings.Add(binding);
        }

    }
}
