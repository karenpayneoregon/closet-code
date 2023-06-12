using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HasQueryFilterApp.Classes;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ShadowProperties.Classes;
using ShadowProperties.Models;
using WindowsFormsLibrary.Classes;
using WindowsFormsLibrary.LanguageExtensions;
#pragma warning disable CS8618
#pragma warning disable CS8622

namespace HasQueryFilterApp
{
    public partial class Form1 : Form
    {
        private BindingList<Contact1> _bindingList;
        private readonly BindingSource _bindingSource = new ();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            
            Shown += OnShown;
        }

        private async void OnShown(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                //await SetupOperations.Initialize();

                _bindingList = new BindingList<Contact1>(await Operations.Contacts());
                _bindingSource.DataSource = _bindingList;
            });

            dataGridView1.DataSource = _bindingSource;
            dataGridView1.ExpandColumns(true);

            UnDeleteButton.Enabled = true;
            DeleteButton.Enabled = true;
            UpdateFirstNameButton.Enabled = true;
            ContactCountsButton.Enabled = true;


        }

        /// <summary>
        /// No prompting as there is zero need for it
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {

            if (_bindingSource.Current is null)
            {
                return;
            }

            FunStuff.Shake(this);
    

            Operations.Remove(_bindingList[_bindingSource.Position]);
            _bindingList.RemoveAt(_bindingSource.Position);

        }

        private async void UnDeleteButton_Click(object sender, EventArgs e)
        {
            var (success, exception) = await Operations.ResetDeleted();
            if (exception is null)
            {
                Dialogs.Information(this,"Un-delete successful, need to restart", "Restart now");
                Application.Restart();
            }
            else
            {
                Dialogs.Information(exception.Message);
            }
        }

        private async void ContactCountsButton_Click(object sender, EventArgs e)
        {
            var (all, filter) = await Operations.GetContact1Counts();
            Dialogs.Information(this, $"All: {all} Filtered: {filter}");
        }


        private void UpdateCurrentContactNameButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
            {
                _bindingList[_bindingSource.Position].FirstName = FirstNameTextBox.Text;
                Operations.Update(_bindingList[_bindingSource.Position]);
            }
        }
    }
}
