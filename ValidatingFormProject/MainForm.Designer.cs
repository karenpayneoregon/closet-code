
namespace ValidatingFormProject
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            CountryComboBox = new ComboBox();
            ValidateButton = new Button();
            CountryGroupBox = new GroupBox();
            FirstNameLabel = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            LastNameLabel = new Label();
            PinLabel = new Label();
            PinTextBox = new TextBox();
            SocailLabel = new Label();
            SocialSecurityNumberTextBox = new TextBox();
            ShowHidePasswordCheckBox = new CheckBox();
            PostalLabel = new Label();
            PostalCodeTextBox = new TextBox();
            BirthDateLabel = new Label();
            CreditCardLabel = new Label();
            CreditCardTextBox = new TextBox();
            AppointmentDateLabel = new Label();
            AppointmentDateTimePicker1 = new WindowsFormsLibrary.Controls.NullableDateTimePicker();
            BirthDatePicker = new WindowsFormsLibrary.Controls.NullableDateTimePicker();
            NotesComboBox = new ComboBox();
            NotesGroupBox = new GroupBox();
            SolutionNameLabel = new Label();
            RestartButton = new Button();
            ColorsListBox = new ListBox();
            CountryGroupBox.SuspendLayout();
            NotesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CountryComboBox
            // 
            CountryComboBox.DropDownHeight = 150;
            CountryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CountryComboBox.FormattingEnabled = true;
            CountryComboBox.IntegralHeight = false;
            CountryComboBox.ItemHeight = 20;
            CountryComboBox.Location = new Point(23, 29);
            CountryComboBox.Margin = new Padding(3, 4, 3, 4);
            CountryComboBox.Name = "CountryComboBox";
            CountryComboBox.Size = new Size(215, 28);
            CountryComboBox.TabIndex = 0;
            // 
            // ValidateButton
            // 
            ValidateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ValidateButton.Image = Properties.Resources.ValidationRule_16x;
            ValidateButton.ImageAlign = ContentAlignment.MiddleLeft;
            ValidateButton.Location = new Point(489, 465);
            ValidateButton.Margin = new Padding(3, 4, 3, 4);
            ValidateButton.Name = "ValidateButton";
            ValidateButton.Size = new Size(83, 48);
            ValidateButton.TabIndex = 1;
            ValidateButton.Text = "Validate";
            ValidateButton.TextAlign = ContentAlignment.MiddleRight;
            ValidateButton.UseVisualStyleBackColor = true;
            ValidateButton.Click += ValidateButton_Click;
            // 
            // CountryGroupBox
            // 
            CountryGroupBox.Controls.Add(CountryComboBox);
            CountryGroupBox.Location = new Point(307, 108);
            CountryGroupBox.Margin = new Padding(3, 4, 3, 4);
            CountryGroupBox.Name = "CountryGroupBox";
            CountryGroupBox.Padding = new Padding(3, 4, 3, 4);
            CountryGroupBox.Size = new Size(258, 100);
            CountryGroupBox.TabIndex = 2;
            CountryGroupBox.TabStop = false;
            CountryGroupBox.Text = "C&ountry";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(18, 17);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(77, 20);
            FirstNameLabel.TabIndex = 3;
            FirstNameLabel.Text = "&First name";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(23, 49);
            FirstNameTextBox.Margin = new Padding(3, 4, 3, 4);
            FirstNameTextBox.MaxLength = 10;
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.PlaceholderText = "place first name here";
            FirstNameTextBox.Size = new Size(187, 27);
            FirstNameTextBox.TabIndex = 4;
            FirstNameTextBox.Text = "Karen";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(23, 124);
            LastNameTextBox.Margin = new Padding(3, 4, 3, 4);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.PlaceholderText = "place last name here";
            LastNameTextBox.Size = new Size(187, 27);
            LastNameTextBox.TabIndex = 6;
            LastNameTextBox.Text = "Payne";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(18, 100);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(76, 20);
            LastNameLabel.TabIndex = 5;
            LastNameLabel.Text = "&Last name";
            // 
            // PinLabel
            // 
            PinLabel.AutoSize = true;
            PinLabel.Location = new Point(286, 17);
            PinLabel.Name = "PinLabel";
            PinLabel.Size = new Size(29, 20);
            PinLabel.TabIndex = 7;
            PinLabel.Text = "Pi&n";
            // 
            // PinTextBox
            // 
            PinTextBox.Location = new Point(320, 17);
            PinTextBox.Margin = new Padding(3, 4, 3, 4);
            PinTextBox.MaxLength = 4;
            PinTextBox.Name = "PinTextBox";
            PinTextBox.Size = new Size(62, 27);
            PinTextBox.TabIndex = 8;
            PinTextBox.Text = "1234";
            // 
            // SocailLabel
            // 
            SocailLabel.AutoSize = true;
            SocailLabel.Location = new Point(281, 60);
            SocailLabel.Name = "SocailLabel";
            SocailLabel.Size = new Size(36, 20);
            SocailLabel.TabIndex = 9;
            SocailLabel.Text = "&SSN";
            // 
            // SocialSecurityNumberTextBox
            // 
            SocialSecurityNumberTextBox.Location = new Point(320, 60);
            SocialSecurityNumberTextBox.Margin = new Padding(3, 4, 3, 4);
            SocialSecurityNumberTextBox.Name = "SocialSecurityNumberTextBox";
            SocialSecurityNumberTextBox.PlaceholderText = "000-00-0000";
            SocialSecurityNumberTextBox.Size = new Size(114, 27);
            SocialSecurityNumberTextBox.TabIndex = 10;
            // 
            // ShowHidePasswordCheckBox
            // 
            ShowHidePasswordCheckBox.AutoSize = true;
            ShowHidePasswordCheckBox.Location = new Point(441, 60);
            ShowHidePasswordCheckBox.Margin = new Padding(3, 4, 3, 4);
            ShowHidePasswordCheckBox.Name = "ShowHidePasswordCheckBox";
            ShowHidePasswordCheckBox.Size = new Size(136, 24);
            ShowHidePasswordCheckBox.TabIndex = 11;
            ShowHidePasswordCheckBox.Text = "Show/Hide SSN";
            ShowHidePasswordCheckBox.UseVisualStyleBackColor = true;
            ShowHidePasswordCheckBox.CheckedChanged += ShowHidePasswordCheckBox_CheckedChanged;
            // 
            // PostalLabel
            // 
            PostalLabel.AutoSize = true;
            PostalLabel.Location = new Point(18, 244);
            PostalLabel.Name = "PostalLabel";
            PostalLabel.Size = new Size(85, 20);
            PostalLabel.TabIndex = 12;
            PostalLabel.Text = "&Postal code";
            // 
            // PostalCodeTextBox
            // 
            PostalCodeTextBox.Location = new Point(23, 268);
            PostalCodeTextBox.Margin = new Padding(3, 4, 3, 4);
            PostalCodeTextBox.Name = "PostalCodeTextBox";
            PostalCodeTextBox.Size = new Size(114, 27);
            PostalCodeTextBox.TabIndex = 13;
            PostalCodeTextBox.Text = "97209";
            // 
            // BirthDateLabel
            // 
            BirthDateLabel.AutoSize = true;
            BirthDateLabel.Location = new Point(18, 176);
            BirthDateLabel.Name = "BirthDateLabel";
            BirthDateLabel.Size = new Size(74, 20);
            BirthDateLabel.TabIndex = 17;
            BirthDateLabel.Text = "Birth &date";
            // 
            // CreditCardLabel
            // 
            CreditCardLabel.AutoSize = true;
            CreditCardLabel.Location = new Point(18, 319);
            CreditCardLabel.Name = "CreditCardLabel";
            CreditCardLabel.Size = new Size(137, 20);
            CreditCardLabel.TabIndex = 18;
            CreditCardLabel.Text = "&Credit card number";
            // 
            // CreditCardTextBox
            // 
            CreditCardTextBox.Location = new Point(23, 343);
            CreditCardTextBox.Margin = new Padding(3, 4, 3, 4);
            CreditCardTextBox.Name = "CreditCardTextBox";
            CreditCardTextBox.Size = new Size(195, 27);
            CreditCardTextBox.TabIndex = 19;
            // 
            // AppointmentDateLabel
            // 
            AppointmentDateLabel.AutoSize = true;
            AppointmentDateLabel.Location = new Point(23, 393);
            AppointmentDateLabel.Name = "AppointmentDateLabel";
            AppointmentDateLabel.Size = new Size(122, 20);
            AppointmentDateLabel.TabIndex = 20;
            AppointmentDateLabel.Text = "Appintment date";
            // 
            // AppointmentDateTimePicker1
            // 
            AppointmentDateTimePicker1.CustomFormat = "";
            AppointmentDateTimePicker1.Format = DateTimePickerFormat.Short;
            AppointmentDateTimePicker1.Location = new Point(23, 429);
            AppointmentDateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            AppointmentDateTimePicker1.Name = "AppointmentDateTimePicker1";
            AppointmentDateTimePicker1.ShowUpDown = true;
            AppointmentDateTimePicker1.Size = new Size(187, 27);
            AppointmentDateTimePicker1.TabIndex = 21;
            AppointmentDateTimePicker1.Value = new DateTime(2022, 5, 7, 8, 54, 53, 185);
            // 
            // BirthDatePicker
            // 
            BirthDatePicker.CustomFormat = "";
            BirthDatePicker.Format = DateTimePickerFormat.Short;
            BirthDatePicker.Location = new Point(23, 200);
            BirthDatePicker.Margin = new Padding(3, 4, 3, 4);
            BirthDatePicker.Name = "BirthDatePicker";
            BirthDatePicker.ShowUpDown = true;
            BirthDatePicker.Size = new Size(187, 27);
            BirthDatePicker.TabIndex = 23;
            BirthDatePicker.Value = new DateTime(2022, 5, 7, 8, 54, 53, 185);
            // 
            // NotesComboBox
            // 
            NotesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            NotesComboBox.FormattingEnabled = true;
            NotesComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            NotesComboBox.Location = new Point(9, 29);
            NotesComboBox.Margin = new Padding(3, 4, 3, 4);
            NotesComboBox.Name = "NotesComboBox";
            NotesComboBox.Size = new Size(138, 28);
            NotesComboBox.TabIndex = 24;
            // 
            // NotesGroupBox
            // 
            NotesGroupBox.Controls.Add(NotesComboBox);
            NotesGroupBox.Location = new Point(311, 216);
            NotesGroupBox.Margin = new Padding(3, 4, 3, 4);
            NotesGroupBox.Name = "NotesGroupBox";
            NotesGroupBox.Padding = new Padding(3, 4, 3, 4);
            NotesGroupBox.Size = new Size(255, 83);
            NotesGroupBox.TabIndex = 25;
            NotesGroupBox.TabStop = false;
            NotesGroupBox.Text = "Notes count";
            // 
            // SolutionNameLabel
            // 
            SolutionNameLabel.AutoSize = true;
            SolutionNameLabel.Location = new Point(18, 491);
            SolutionNameLabel.Name = "SolutionNameLabel";
            SolutionNameLabel.Size = new Size(105, 20);
            SolutionNameLabel.TabIndex = 26;
            SolutionNameLabel.Text = "Solution name";
            // 
            // RestartButton
            // 
            RestartButton.Image = Properties.Resources.Exit_16x;
            RestartButton.ImageAlign = ContentAlignment.MiddleLeft;
            RestartButton.Location = new Point(375, 465);
            RestartButton.Margin = new Padding(3, 4, 3, 4);
            RestartButton.Name = "RestartButton";
            RestartButton.Size = new Size(83, 48);
            RestartButton.TabIndex = 27;
            RestartButton.Text = "Restart";
            RestartButton.TextAlign = ContentAlignment.MiddleRight;
            RestartButton.UseVisualStyleBackColor = true;
            RestartButton.Click += RestartButton_Click;
            // 
            // ColorsListBox
            // 
            ColorsListBox.FormattingEnabled = true;
            ColorsListBox.Items.AddRange(new object[] { "Bisque", "LightBlue", "Tomato", "Aquamarine", "DarkKhaki", "OrangeRed", "SlateBlue", "IndianRed", "AliceBlue", "Silver" });
            ColorsListBox.Location = new Point(311, 299);
            ColorsListBox.Name = "ColorsListBox";
            ColorsListBox.Size = new Size(150, 124);
            ColorsListBox.TabIndex = 28;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 523);
            Controls.Add(ColorsListBox);
            Controls.Add(RestartButton);
            Controls.Add(SolutionNameLabel);
            Controls.Add(NotesGroupBox);
            Controls.Add(BirthDatePicker);
            Controls.Add(AppointmentDateTimePicker1);
            Controls.Add(AppointmentDateLabel);
            Controls.Add(CreditCardTextBox);
            Controls.Add(CreditCardLabel);
            Controls.Add(BirthDateLabel);
            Controls.Add(PostalCodeTextBox);
            Controls.Add(PostalLabel);
            Controls.Add(ShowHidePasswordCheckBox);
            Controls.Add(SocialSecurityNumberTextBox);
            Controls.Add(SocailLabel);
            Controls.Add(PinTextBox);
            Controls.Add(PinLabel);
            Controls.Add(LastNameTextBox);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameTextBox);
            Controls.Add(FirstNameLabel);
            Controls.Add(CountryGroupBox);
            Controls.Add(ValidateButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validation code sample";
            CountryGroupBox.ResumeLayout(false);
            NotesGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox CountryComboBox;
        private System.Windows.Forms.Button ValidateButton;
        private System.Windows.Forms.GroupBox CountryGroupBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label PinLabel;
        private System.Windows.Forms.TextBox PinTextBox;
        private System.Windows.Forms.Label SocailLabel;
        private System.Windows.Forms.TextBox SocialSecurityNumberTextBox;
        private System.Windows.Forms.CheckBox ShowHidePasswordCheckBox;
        private System.Windows.Forms.Label PostalLabel;
        private System.Windows.Forms.TextBox PostalCodeTextBox;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.Label CreditCardLabel;
        private System.Windows.Forms.TextBox CreditCardTextBox;
        private System.Windows.Forms.Label AppointmentDateLabel;
        private WindowsFormsLibrary.Controls.NullableDateTimePicker AppointmentDateTimePicker1;
        private WindowsFormsLibrary.Controls.NullableDateTimePicker BirthDatePicker;
        private System.Windows.Forms.ComboBox NotesComboBox;
        private System.Windows.Forms.GroupBox NotesGroupBox;
        private System.Windows.Forms.Label SolutionNameLabel;
        private System.Windows.Forms.Button RestartButton;
        private ListBox ColorsListBox;
    }
}

