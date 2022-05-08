
namespace CheckedListBoxExtensionsApp
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
            this.CompaniesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GetButton = new System.Windows.Forms.Button();
            this.ClearCheckedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CompaniesCheckedListBox
            // 
            this.CompaniesCheckedListBox.FormattingEnabled = true;
            this.CompaniesCheckedListBox.Location = new System.Drawing.Point(12, 12);
            this.CompaniesCheckedListBox.Name = "CompaniesCheckedListBox";
            this.CompaniesCheckedListBox.Size = new System.Drawing.Size(202, 220);
            this.CompaniesCheckedListBox.TabIndex = 0;
            // 
            // ResultsDataGridView
            // 
            this.ResultsDataGridView.AllowUserToAddRows = false;
            this.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.ResultsDataGridView.Location = new System.Drawing.Point(220, 12);
            this.ResultsDataGridView.Name = "ResultsDataGridView";
            this.ResultsDataGridView.RowTemplate.Height = 25;
            this.ResultsDataGridView.Size = new System.Drawing.Size(303, 220);
            this.ResultsDataGridView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // GetButton
            // 
            this.GetButton.Location = new System.Drawing.Point(529, 12);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(75, 23);
            this.GetButton.TabIndex = 2;
            this.GetButton.Text = "Get";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // ClearCheckedButton
            // 
            this.ClearCheckedButton.Location = new System.Drawing.Point(12, 238);
            this.ClearCheckedButton.Name = "ClearCheckedButton";
            this.ClearCheckedButton.Size = new System.Drawing.Size(202, 23);
            this.ClearCheckedButton.TabIndex = 3;
            this.ClearCheckedButton.Text = "Clear";
            this.ClearCheckedButton.UseVisualStyleBackColor = true;
            this.ClearCheckedButton.Click += new System.EventHandler(this.ClearCheckedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 304);
            this.Controls.Add(this.ClearCheckedButton);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.ResultsDataGridView);
            this.Controls.Add(this.CompaniesCheckedListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generic CheckedListBox example";
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CompaniesCheckedListBox;
        private System.Windows.Forms.DataGridView ResultsDataGridView;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button ClearCheckedButton;
    }
}

