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
using EnumDescriptions.Classes;
using EnumDescriptions.Extensions;
using EnumerationLibrary.Classes;
using WindowsFormsLibrary.Classes;
#pragma warning disable CS8622

namespace EnumDescriptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private readonly BindingSource _bindingSource = new ();
        private void OnShown(object sender, EventArgs e)
        {
            CategoriesComboBox.DisplayMember = "Description";
            CategoriesComboBox.ValueMember = "Value";

            _bindingSource.DataSource = Operations.GetItems<Categories>();
            CategoriesComboBox.DataSource = _bindingSource;

            label1.DataBindings.Add("Text", _bindingSource, nameof(ItemContainer.Description));
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            var (text, category) = CategoriesComboBox.Current<Categories>();
            Dialogs.Information(this, $"Description: {text}\nEnum: {category}");
        }
    }
}
