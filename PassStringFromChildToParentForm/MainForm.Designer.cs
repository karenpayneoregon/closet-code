
namespace PassStringFromChildToParentForm
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MonthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowChildForm = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonthColumn});
            this.dataGridView1.Location = new System.Drawing.Point(11, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(320, 359);
            this.dataGridView1.TabIndex = 0;
            // 
            // MonthColumn
            // 
            this.MonthColumn.HeaderText = "Month";
            this.MonthColumn.MinimumWidth = 6;
            this.MonthColumn.Name = "MonthColumn";
            this.MonthColumn.Width = 125;
            // 
            // ShowChildForm
            // 
            this.ShowChildForm.Location = new System.Drawing.Point(11, 382);
            this.ShowChildForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowChildForm.Name = "ShowChildForm";
            this.ShowChildForm.Size = new System.Drawing.Size(320, 28);
            this.ShowChildForm.TabIndex = 1;
            this.ShowChildForm.Text = "Show";
            this.ShowChildForm.UseVisualStyleBackColor = true;
            this.ShowChildForm.Click += new System.EventHandler(this.ShowChildForm_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(11, 417);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(320, 28);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 480);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ShowChildForm);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthColumn;
        private System.Windows.Forms.Button ShowChildForm;
        private System.Windows.Forms.Button SendButton;
    }
}

