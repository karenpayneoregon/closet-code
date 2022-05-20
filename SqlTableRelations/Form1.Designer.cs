namespace SqlTableRelations
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableInformationComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GetInformationButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.FieldColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FieldOrderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LenthColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrecisionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScaleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AllowNullsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdentityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrimaryKeyColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ForeignKeyColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RelatedTableColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableInformationComboBox
            // 
            this.tableInformationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableInformationComboBox.FormattingEnabled = true;
            this.tableInformationComboBox.Location = new System.Drawing.Point(12, 21);
            this.tableInformationComboBox.Name = "tableInformationComboBox";
            this.tableInformationComboBox.Size = new System.Drawing.Size(193, 21);
            this.tableInformationComboBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GetInformationButton);
            this.panel1.Controls.Add(this.tableInformationComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 56);
            this.panel1.TabIndex = 1;
            // 
            // GetInformationButton
            // 
            this.GetInformationButton.Location = new System.Drawing.Point(221, 19);
            this.GetInformationButton.Name = "GetInformationButton";
            this.GetInformationButton.Size = new System.Drawing.Size(75, 23);
            this.GetInformationButton.TabIndex = 0;
            this.GetInformationButton.Text = "Populate";
            this.GetInformationButton.UseVisualStyleBackColor = true;
            this.GetInformationButton.Click += new System.EventHandler(this.GetInformationButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FieldColumn,
            this.FieldOrderColumn,
            this.DataTypeColumn,
            this.LenthColumn,
            this.PrecisionColumn,
            this.ScaleColumn,
            this.AllowNullsColumn,
            this.IdentityColumn,
            this.PrimaryKeyColumn,
            this.ForeignKeyColumn,
            this.RelatedTableColumn});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(743, 357);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // FieldColumn
            // 
            this.FieldColumn.Tag = "FieldColumn";
            this.FieldColumn.Text = "Field";
            this.FieldColumn.Width = 50;
            // 
            // FieldOrderColumn
            // 
            this.FieldOrderColumn.Tag = "FieldOrderColumn";
            this.FieldOrderColumn.Text = "Field Order";
            this.FieldOrderColumn.Width = 120;
            // 
            // DataTypeColumn
            // 
            this.DataTypeColumn.Tag = "DataTypeColumn";
            this.DataTypeColumn.Text = "Data type";
            this.DataTypeColumn.Width = 80;
            // 
            // LenthColumn
            // 
            this.LenthColumn.Tag = "LenthColumn";
            this.LenthColumn.Text = "Length";
            // 
            // PrecisionColumn
            // 
            this.PrecisionColumn.Tag = "PrecisionColumn";
            this.PrecisionColumn.Text = "Precision";
            // 
            // ScaleColumn
            // 
            this.ScaleColumn.Tag = "ScaleColumn";
            this.ScaleColumn.Text = "Scale";
            // 
            // AllowNullsColumn
            // 
            this.AllowNullsColumn.Tag = "AllowNullsColumn";
            this.AllowNullsColumn.Text = "Allow Nulls";
            // 
            // IdentityColumn
            // 
            this.IdentityColumn.Tag = "IdentityColumn";
            this.IdentityColumn.Text = "Identity";
            // 
            // PrimaryKeyColumn
            // 
            this.PrimaryKeyColumn.Tag = "PrimaryKeyColumn";
            this.PrimaryKeyColumn.Text = "PrimaryKey";
            // 
            // ForeignKeyColumn
            // 
            this.ForeignKeyColumn.Tag = "ForeignKeyColumn";
            this.ForeignKeyColumn.Text = "ForeignKey";
            // 
            // RelatedTableColumn
            // 
            this.RelatedTableColumn.Tag = "RelatedTableColumn";
            this.RelatedTableColumn.Text = "Related Table";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Description";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.Color.White;
            this.DescriptionTextBox.Location = new System.Drawing.Point(78, 363);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(665, 20);
            this.DescriptionTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View table information in specific database";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tableInformationComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GetInformationButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader FieldColumn;
        private System.Windows.Forms.ColumnHeader FieldOrderColumn;
        private System.Windows.Forms.ColumnHeader DataTypeColumn;
        private System.Windows.Forms.ColumnHeader LenthColumn;
        private System.Windows.Forms.ColumnHeader PrecisionColumn;
        private System.Windows.Forms.ColumnHeader ScaleColumn;
        private System.Windows.Forms.ColumnHeader AllowNullsColumn;
        private System.Windows.Forms.ColumnHeader IdentityColumn;
        private System.Windows.Forms.ColumnHeader PrimaryKeyColumn;
        private System.Windows.Forms.ColumnHeader ForeignKeyColumn;
        private System.Windows.Forms.ColumnHeader RelatedTableColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescriptionTextBox;
    }
}

