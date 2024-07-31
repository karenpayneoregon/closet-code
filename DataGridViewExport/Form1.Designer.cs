
namespace DataGridViewExport
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            FirstNameColumn = new DataGridViewTextBoxColumn();
            LastColumn = new DataGridViewTextBoxColumn();
            PhoneColumn = new DataGridViewTextBoxColumn();
            EmailColumn = new DataGridViewTextBoxColumn();
            BirthDateColumn = new DataGridViewTextBoxColumn();
            ExportButton = new Button();
            label1 = new Label();
            IdLabel = new Label();
            EditCurrentButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdColumn, FirstNameColumn, LastColumn, PhoneColumn, EmailColumn, BirthDateColumn });
            dataGridView1.Location = new Point(14, 16);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(807, 507);
            dataGridView1.TabIndex = 0;
            // 
            // IdColumn
            // 
            IdColumn.DataPropertyName = "Id";
            IdColumn.HeaderText = "Id";
            IdColumn.MinimumWidth = 6;
            IdColumn.Name = "IdColumn";
            IdColumn.Visible = false;
            IdColumn.Width = 125;
            // 
            // FirstNameColumn
            // 
            FirstNameColumn.DataPropertyName = "FirstName";
            FirstNameColumn.HeaderText = "First";
            FirstNameColumn.MinimumWidth = 6;
            FirstNameColumn.Name = "FirstNameColumn";
            FirstNameColumn.Width = 125;
            // 
            // LastColumn
            // 
            LastColumn.DataPropertyName = "LastName";
            LastColumn.HeaderText = "Last";
            LastColumn.MinimumWidth = 6;
            LastColumn.Name = "LastColumn";
            LastColumn.Width = 125;
            // 
            // PhoneColumn
            // 
            PhoneColumn.DataPropertyName = "Phone";
            PhoneColumn.HeaderText = "Phone";
            PhoneColumn.MinimumWidth = 6;
            PhoneColumn.Name = "PhoneColumn";
            PhoneColumn.Width = 125;
            // 
            // EmailColumn
            // 
            EmailColumn.DataPropertyName = "Email";
            EmailColumn.HeaderText = "Mail";
            EmailColumn.MinimumWidth = 6;
            EmailColumn.Name = "EmailColumn";
            EmailColumn.Width = 125;
            // 
            // BirthDateColumn
            // 
            BirthDateColumn.DataPropertyName = "BirthDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            BirthDateColumn.DefaultCellStyle = dataGridViewCellStyle1;
            BirthDateColumn.HeaderText = "Birth";
            BirthDateColumn.MinimumWidth = 6;
            BirthDateColumn.Name = "BirthDateColumn";
            BirthDateColumn.Width = 125;
            // 
            // ExportButton
            // 
            ExportButton.Location = new Point(14, 540);
            ExportButton.Margin = new Padding(3, 4, 3, 4);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(86, 31);
            ExportButton.TabIndex = 1;
            ExportButton.Text = "Export";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 545);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 2;
            label1.Text = "Current id";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(221, 545);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(33, 20);
            IdLabel.TabIndex = 3;
            IdLabel.Text = "000";
            // 
            // EditCurrentButton
            // 
            EditCurrentButton.Location = new Point(668, 545);
            EditCurrentButton.Name = "EditCurrentButton";
            EditCurrentButton.Size = new Size(153, 29);
            EditCurrentButton.TabIndex = 4;
            EditCurrentButton.Text = "Edit current";
            EditCurrentButton.UseVisualStyleBackColor = true;
            EditCurrentButton.Click += EditCurrentButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 600);
            Controls.Add(EditCurrentButton);
            Controls.Add(IdLabel);
            Controls.Add(label1);
            Controls.Add(ExportButton);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Export to file";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDateColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IdLabel;
        private Button EditCurrentButton;
    }
}

