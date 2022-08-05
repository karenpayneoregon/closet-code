using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using CheckedListBoxExtensionsApp1.Classes;
using CheckedListBoxExtensionsApp1.Extensions;
using CheckedListBoxExtensionsApp1.Models;

namespace CheckedListBoxExtensionsApp1
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new ();
        protected BindingList<Company> _bindingList = new();

        public Form1()
        {
            InitializeComponent();

            this.StyleForm();

            ResultsDataGridView.AutoGenerateColumns = false;

            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            _bindingSource.DataSource = _bindingList;
            ResultsDataGridView.DataSource = _bindingSource;

            List<Company> companies = BogusOperations.Companies();
            CompaniesCheckedListBox.DataSource = companies;

            _bindingList.Add(companies[0]);
            CompaniesCheckedListBox.SetItemCheckState(0,CheckState.Checked);
            _bindingList.Add(companies[4]);
            CompaniesCheckedListBox.SetItemCheckState(4, CheckState.Checked);
            ResultsDataGridView.ExpandColumns();

            CompaniesCheckedListBox.ItemCheck += CompaniesCheckedListBoxOnItemCheck;
        }

        private void CompaniesCheckedListBoxOnItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue != CheckState.Unchecked) return;
            var currentCompany = (Company)CompaniesCheckedListBox.SelectedItem;
            var index = _bindingList.IndexOf(currentCompany);
            if (index > -1)
            {
                _bindingList.Remove(currentCompany);
            }
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
