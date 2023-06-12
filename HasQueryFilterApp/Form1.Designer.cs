
namespace HasQueryFilterApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpdateFirstNameButton = new System.Windows.Forms.Button();
            this.ContactCountsButton = new System.Windows.Forms.Button();
            this.UnDeleteButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(398, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ContactId";
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FirstName";
            this.Column2.HeaderText = "First";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LastName";
            this.Column3.HeaderText = "Last";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FirstNameTextBox);
            this.panel1.Controls.Add(this.UpdateFirstNameButton);
            this.panel1.Controls.Add(this.ContactCountsButton);
            this.panel1.Controls.Add(this.UnDeleteButton);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 375);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 93);
            this.panel1.TabIndex = 1;
            // 
            // UpdateFirstNameButton
            // 
            this.UpdateFirstNameButton.Enabled = false;
            this.UpdateFirstNameButton.Location = new System.Drawing.Point(14, 49);
            this.UpdateFirstNameButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateFirstNameButton.Name = "UpdateFirstNameButton";
            this.UpdateFirstNameButton.Size = new System.Drawing.Size(182, 31);
            this.UpdateFirstNameButton.TabIndex = 4;
            this.UpdateFirstNameButton.Text = "Set current first name";
            this.UpdateFirstNameButton.UseVisualStyleBackColor = true;
            this.UpdateFirstNameButton.Click += new System.EventHandler(this.UpdateCurrentContactNameButton_Click);
            // 
            // ContactCountsButton
            // 
            this.ContactCountsButton.Enabled = false;
            this.ContactCountsButton.Location = new System.Drawing.Point(110, 8);
            this.ContactCountsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContactCountsButton.Name = "ContactCountsButton";
            this.ContactCountsButton.Size = new System.Drawing.Size(86, 31);
            this.ContactCountsButton.TabIndex = 3;
            this.ContactCountsButton.Text = "Counts";
            this.ContactCountsButton.UseVisualStyleBackColor = true;
            this.ContactCountsButton.Click += new System.EventHandler(this.ContactCountsButton_Click);
            // 
            // UnDeleteButton
            // 
            this.UnDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UnDeleteButton.Enabled = false;
            this.UnDeleteButton.Location = new System.Drawing.Point(298, 8);
            this.UnDeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UnDeleteButton.Name = "UnDeleteButton";
            this.UnDeleteButton.Size = new System.Drawing.Size(86, 31);
            this.UnDeleteButton.TabIndex = 2;
            this.UnDeleteButton.Text = "Undelete";
            this.UnDeleteButton.UseVisualStyleBackColor = true;
            this.UnDeleteButton.Click += new System.EventHandler(this.UnDeleteButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(14, 8);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(86, 31);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(202, 51);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(182, 27);
            this.FirstNameTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 468);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shadow properties";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UnDeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button ContactCountsButton;
        private Button UpdateFirstNameButton;
        private TextBox FirstNameTextBox;
    }
}

