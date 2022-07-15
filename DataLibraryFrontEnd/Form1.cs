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
using DataLibrary.Classes;
using DataLibrary.Models;

namespace DataLibraryFrontEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Shown += OnShown;
        }

        /// <summary>
        /// SqlServerOperations.Countries() is not read-only so
        /// it's possible to add, delete and modify properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnShown(object sender, EventArgs e)
        {
            var list = SqlServerOperations.Countries();
            list[0].Name = "Make a selection";
            CountryComboBox.DataSource = list;

            IReadOnlyList<CountryItem> list1 = SqlServerOperations.CountriesReadOnly();
            //not possible -- list1[0].Name = "";
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            
            Country currentCountry = (Country)CountryComboBox.SelectedItem;

            MessageBox.Show(currentCountry.Id == -1 ? 
                "Please make a selection" : 
                $"Identifier = {currentCountry.Id}");

        }
    }
}
