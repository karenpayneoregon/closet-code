namespace SelectAll
{
    partial class frmSelectAll
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSelectAll = new System.Windows.Forms.DataGridView();
            this.chkBxSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtBxRandomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBxDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBxTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectAll)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelectAll
            // 
            this.dgvSelectAll.AllowUserToAddRows = false;
            this.dgvSelectAll.AllowUserToDeleteRows = false;
            this.dgvSelectAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkBxSelect,
            this.txtBxRandomNo,
            this.txtBxDate,
            this.txtBxTime});
            this.dgvSelectAll.Location = new System.Drawing.Point(12, 12);
            this.dgvSelectAll.Name = "dgvSelectAll";
            this.dgvSelectAll.Size = new System.Drawing.Size(443, 245);
            this.dgvSelectAll.TabIndex = 0;
            // 
            // chkBxSelect
            // 
            this.chkBxSelect.DataPropertyName = "IsChecked";
            this.chkBxSelect.HeaderText = "";
            this.chkBxSelect.Name = "chkBxSelect";
            this.chkBxSelect.Width = 50;
            // 
            // txtBxRandomNo
            // 
            this.txtBxRandomNo.DataPropertyName = "RandomNo";
            this.txtBxRandomNo.HeaderText = "Random No";
            this.txtBxRandomNo.Name = "txtBxRandomNo";
            this.txtBxRandomNo.ReadOnly = true;
            this.txtBxRandomNo.Width = 150;
            // 
            // txtBxDate
            // 
            this.txtBxDate.DataPropertyName = "Date";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.txtBxDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.txtBxDate.HeaderText = "Date";
            this.txtBxDate.Name = "txtBxDate";
            this.txtBxDate.ReadOnly = true;
            // 
            // txtBxTime
            // 
            this.txtBxTime.DataPropertyName = "Time";
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            this.txtBxTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.txtBxTime.HeaderText = "Time";
            this.txtBxTime.Name = "txtBxTime";
            this.txtBxTime.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSelectAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 313);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSelectAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSelectAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select All Demo";
            this.Load += new System.EventHandler(this.frmSelectAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelectAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkBxSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBxRandomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBxDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBxTime;
        private System.Windows.Forms.Button button1;
    }
}

