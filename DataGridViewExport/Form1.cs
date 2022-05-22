using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public Form1()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;

            BindingList<Contact> bindingList = new SortableBindingList<Contact>(
                CreateOperations.Contacts(500));

            _bindingSource.DataSource = bindingList;
            dataGridView1.DataSource = _bindingSource;
            
            dataGridView1.ExpandColumns();

            IdLabel.DataBindings.Add("Text", _bindingSource, nameof(Contact.Id));
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            dataGridView1.ExportRows("contacts.csv");
            Shake(this);
        }
    }
}
