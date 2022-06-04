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
using DirectoryHelpersLibrary.Classes;
using ValidatingFormProject.Classes;
using ValidatingFormProject.Extensions;
using WindowsFormsLibrary.Classes;
using static BaseDataValidatorLibrary.Helpers.ValidationHelper;
using Customer = ValidatingFormProject.Models.Customer;

namespace ValidatingFormProject
{
    public partial class MainForm : Form
    {

        private readonly BindingSource _customerBindingSource = new();
        public MainForm()
        {
            InitializeComponent();
            
            Shown += MainForm_Shown;

            SolutionNameLabel.Text = Folders.CurrentSolutionName();

            Move += OnTheMove;
        }

        private void OnTheMove(object sender, EventArgs e)
        {
            MoveChildForm();
        }

        private void MoveChildForm()
        {
            var childForms = Application.OpenForms.Cast<Form>()
                .Where(form => form.Name == nameof(SideForm));

            if (childForms.Any())
            {
                foreach (var currentChildForm in childForms)
                {
                    currentChildForm.Top = Top;
                    currentChildForm.Left = 
                        currentChildForm.Tag.ToString() == "Left" ? (Left - Width) + 120 : (Left + Width) ;
                }
            }
        }

        private void SetResultTextInChildWindow(string text = "")
        {
            var childForms = Application.OpenForms.Cast<Form>()
                .Where(form => form.Name == nameof(SideForm));

            if (childForms.Any())
            {
                var list = childForms.Select(x => (SideForm)x).ToList();
                foreach (var sideForm in list)
                {
                    sideForm.ErrorsTextBox.Text = text;
                }
            }
            else
            {
                var childForm1 = new SideForm() { Top = Top, Left = (Left + Width), Tag = "Right" };
                childForm1.Show();
                MoveChildForm();
                childForm1.ErrorsTextBox.Text = text;
            }
        }



        private void MainForm_Shown(object sender, EventArgs e)
        {
            CountryComboBox.DataSource = Operations.Countries();

            // so we start-off with a valid Customer
            CountryComboBox.SelectedIndex = 1;

            SocialSecurityNumberTextBox.ToggleShow(false);

            // This sets up for binding to the sole customer
            _customerBindingSource.DataSource = Operations.Customers;

            // data bind to customer properties
            FirstNameTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.FirstName));
            LastNameTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.LastName));
            BirthDatePicker.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.BirthDate), true, DataSourceUpdateMode.OnPropertyChanged);
            PinTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.Pin));
            SocialSecurityNumberTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.SocialSecurity));
            PostalCodeTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.PostalCode));
            CountryComboBox.DataBindings.Add(new Binding("SelectedValue", _customerBindingSource, nameof(Customer.Country), true, DataSourceUpdateMode.OnPropertyChanged));
            CreditCardTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.CreditCardNumber));
            AppointmentDateTimePicker1.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.AppointmentDate));

            NotesComboBox.SelectedIndex = 3;
            _customerBindingSource.Customer().NotesList = Operations.CreateNotes();

            var childForm1 = new SideForm() { Top = Top, Left = (Left + Width), Tag = "Right" };
            childForm1.Show();
            MoveChildForm();

        }

        private void ShowHidePasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SocialSecurityNumberTextBox.ToggleShow(ShowHidePasswordCheckBox.Checked);
        }

        private void ValidateButton_Click(object sender, EventArgs e)
        {
            if (_customerBindingSource.Current is null)
            {
                Dialogs.Information(this, "Customer is in an invalid state");
            }
            else
            {
                var customer = _customerBindingSource.Customer();

                customer.NotesList = Operations.CreateNotes(Convert.ToInt32(NotesComboBox.Text));
                var (success, errorMessages) = IsValidEntity(customer);

                if (!success)
                {
                    FunStuff.Shake(this);
                    SetResultTextInChildWindow(errorMessages);
                }
                else
                {
                    SetResultTextInChildWindow();
                    Dialogs.Information(this, "Valid");
                }
            }

        }

        /// <summary>
        /// Cheap way to reset values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
