﻿using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace PassStringFromChildToParentForm
{
    public partial class MainForm : Form
    {
        private ChildForm _childForm;
        public MainForm()
        {
            InitializeComponent();
            MaleRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            FemaleRadioButton.CheckedChanged += RadioButton_CheckedChanged;
        }

        /// <summary>
        /// If child form is open, push change notification of which
        /// RadioButton is selected
        /// </summary>
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ChildForm>().Count() != 1) return;
            var radioButton = (RadioButton)sender;
            if (!radioButton.Checked) return;
            if (!radioButton.Checked) return;
            _childForm.UpdateRadioButton(MaleRadioButton.Checked);

        }

        private void ShowChildForm_Click(object sender, EventArgs e)
        {
            _childForm = new ChildForm();
            _childForm.PassData += ChildForm_PassData; ;
            _childForm.ClickSomeButton += _childForm_ClickSomeButton;
            _childForm.Show(this);
            _childForm.Left = (this.Left + this.Width) + 10;
            _childForm.Top = Top;

        }

        private void _childForm_ClickSomeButton()
        {
            DoSomething();
        }

        private void ChildForm_PassData(bool isMale)
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

        private void DummyButton_Click(object sender, EventArgs e)
        {
            DoSomething();
        }
        private void DoSomething()

        {

            MessageBox.Show("Do some work");

        }
    }
}
