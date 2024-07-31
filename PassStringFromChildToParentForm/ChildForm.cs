using System;
using System.Windows.Forms;

namespace PassStringFromChildToParentForm
{
    public partial class ChildForm : Form
    {
        public delegate void OnPassData(bool isMale);
        public event OnPassData PassData;


        public delegate void OnPassInformation(string sender);
        public event OnPassInformation PassInformation;

        public delegate void OnClickSomeButton();

        public event OnClickSomeButton ClickSomeButton;

        /// <summary>
        /// Note we could create an overload of this constructor
        /// and pass Male or Female
        /// </summary>
        public ChildForm()
        {
            InitializeComponent();

            MaleRadioButton.Checked = true;
            MaleRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            FemaleRadioButton.CheckedChanged += RadioButton_CheckedChanged;

        }

        /// <summary>
        /// Tell listeners (forms) which RadioButton is selected
        /// </summary>
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                PassData?.Invoke(radioButton == MaleRadioButton);
            }
        }

        /// <summary>
        /// Another form is indicating the selected RadioButton changed,
        /// update accordingly.
        /// </summary>
        /// <param name="isMale">Indicates if the selection is male, not female</param>
        public void UpdateRadioButton(bool isMale)
        {
            if (isMale)
            {
                MaleRadioButton.Checked = true;
            }
            else
            {
                FemaleRadioButton.Checked = true;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
            {
                PassInformation?.Invoke(FirstNameTextBox.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Need a first name");
            }
        }

        private void InvokeButton_Click(object sender, EventArgs e)
        {
            ClickSomeButton?.Invoke();
        }
    }
}
