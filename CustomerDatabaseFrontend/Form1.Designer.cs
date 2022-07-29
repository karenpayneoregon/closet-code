
namespace CustomerDatabaseFrontend
{
    partial class Form1
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
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.ContactTypeCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ContactNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelSaveButton = new System.Windows.Forms.Button();
            this.SaveEntityFramework = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Location = new System.Drawing.Point(12, 203);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(145, 23);
            this.GenderComboBox.TabIndex = 0;
            // 
            // ContactTypeCombobox
            // 
            this.ContactTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ContactTypeCombobox.FormattingEnabled = true;
            this.ContactTypeCombobox.Location = new System.Drawing.Point(12, 133);
            this.ContactTypeCombobox.Name = "ContactTypeCombobox";
            this.ContactTypeCombobox.Size = new System.Drawing.Size(145, 23);
            this.ContactTypeCombobox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Company name";
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Location = new System.Drawing.Point(12, 27);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(196, 23);
            this.CompanyNameTextBox.TabIndex = 3;
            this.CompanyNameTextBox.Text = "ABC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contact name";
            // 
            // ContactNameTextBox
            // 
            this.ContactNameTextBox.Location = new System.Drawing.Point(12, 83);
            this.ContactNameTextBox.Name = "ContactNameTextBox";
            this.ContactNameTextBox.Size = new System.Drawing.Size(196, 23);
            this.ContactNameTextBox.TabIndex = 5;
            this.ContactNameTextBox.Text = "Karen Payne";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contact type";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 247);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(158, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save conventional";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelSaveButton
            // 
            this.CancelSaveButton.Location = new System.Drawing.Point(176, 247);
            this.CancelSaveButton.Name = "CancelSaveButton";
            this.CancelSaveButton.Size = new System.Drawing.Size(109, 23);
            this.CancelSaveButton.TabIndex = 9;
            this.CancelSaveButton.Text = "Cancel";
            this.CancelSaveButton.UseVisualStyleBackColor = true;
            this.CancelSaveButton.Click += new System.EventHandler(this.CancelSaveButton_Click);
            // 
            // SaveEntityFramework
            // 
            this.SaveEntityFramework.Location = new System.Drawing.Point(12, 276);
            this.SaveEntityFramework.Name = "SaveEntityFramework";
            this.SaveEntityFramework.Size = new System.Drawing.Size(158, 23);
            this.SaveEntityFramework.TabIndex = 10;
            this.SaveEntityFramework.Text = "Save conventional";
            this.SaveEntityFramework.UseVisualStyleBackColor = true;
            this.SaveEntityFramework.Click += new System.EventHandler(this.SaveEntityFramework_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 307);
            this.Controls.Add(this.SaveEntityFramework);
            this.Controls.Add(this.CancelSaveButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ContactNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CompanyNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContactTypeCombobox);
            this.Controls.Add(this.GenderComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database operations sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.ComboBox ContactTypeCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CompanyNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ContactNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelSaveButton;
        private System.Windows.Forms.Button SaveEntityFramework;
    }
}

