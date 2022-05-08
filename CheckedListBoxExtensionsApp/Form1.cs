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
using CheckedListBoxExtensionsApp.Classes;
using CheckedListBoxExtensionsApp.Extensions;
using CheckedListBoxExtensionsApp.Models;

namespace CheckedListBoxExtensionsApp
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new ();
        protected BindingList<Company> _bindingList = new();

        public Form1()
        {
            InitializeComponent();

            ResultsDataGridView.AutoGenerateColumns = false;

            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            _bindingSource.DataSource = _bindingList;
            ResultsDataGridView.DataSource = _bindingSource;

            CompaniesCheckedListBox.DataSource = BogusOperations.Companies();
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            List<Company> result = CompaniesCheckedListBox.CheckedList<Company>();

            if (result.Count == 0)
            {
                _bindingList.Clear();
                return;
            }

            foreach (var company in result)
            {
                if (!_bindingList.Contains(company))
                {
                    _bindingList.Add(company);
                }

            }

            ResultsDataGridView.ExpandColumns();
        }

        private void ClearCheckedButton_Click(object sender, EventArgs e)
        {
            CompaniesCheckedListBox.UnCheckAll();

            if (_bindingList.Count >0)
            {
                _bindingList.Clear();
            }
        }
    }
}
