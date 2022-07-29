using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerDatabaseLibrary.Classes;
using CustomerDatabaseLibrary.Models;

namespace CustomerDatabaseFrontend
{
    public partial class Form1 : Form
    {

        private Customer _customer;
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            GenderComboBox.DataSource = DataOperations.GendersList();
            ContactTypeCombobox.DataSource = DataOperations.ContactTypesList();
        }

        private void CancelSaveButton_Click(object sender, EventArgs e)
        {
            // User cancelled
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            /*
             * Do validation here, abort if validation fails
             *
             * Check 1, GenderComboBox selected index is not 0
             * Check 2, ContactTypeCombobox selected index is not 0
             * Check 3, CompanyNameTextBox.Text is not an empty string
             * Check 4, ContactNameTextBox.Text is not an empty string
             *
             * For check 3 and 4 consider data annotations
             */
            _customer = new Customer
            {
                CompanyName = CompanyNameTextBox.Text,
                ContactName = ContactNameTextBox.Text,
                GenderIdentifier = ((Genders)GenderComboBox.SelectedItem).id,
                ContactTypeIdentifier = ((ContactTypes)ContactTypeCombobox.SelectedItem).Identifier
            };

            DataOperations.AddCustomer(_customer);
            MessageBox.Show($"{_customer.Identifier}");
        }
    }
}
