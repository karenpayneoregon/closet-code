﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using BindingListLibrary;
using DataGridViewExport.Classes;
using DataGridViewExport.Extensions;
using DataGridViewExport.Models;
using static DataGridViewExport.Classes.FunStuff;

namespace DataGridViewExport
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// We don't need this for the code sample but one should always consider using one
        /// </summary>
        private readonly BindingSource _bindingSource = new ();

        private readonly BindingList<Contact> _bindingList;
        public Form1()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;

            _bindingList = new SortableBindingList<Contact>(CreateOperations.Contacts(500));

            _bindingSource.DataSource = _bindingList;
            dataGridView1.DataSource = _bindingSource;
            
            dataGridView1.ExpandColumns();

            IdLabel.DataBindings.Add("Text", _bindingSource, nameof(Contact.Id));
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            dataGridView1.ExportRows("contacts.csv");
            
            Shake(this);
        }

        private void UpdateFirstNameTextBox_Click(object sender, EventArgs e)
        {
            _bindingList[_bindingSource.Position].FirstName = FirstNameTextBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contact contact = _bindingSource.List.OfType<Contact>().ToList().Find( x => x.FirstName == textBox1.Text);

            contact.FirstName = "Karen";
        }
    }
}
