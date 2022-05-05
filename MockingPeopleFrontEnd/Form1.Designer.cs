
namespace MockingPeopleFrontEnd
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
            this.CreateNewDatabaseButton = new System.Windows.Forms.Button();
            this.PopulateDatabaseButton = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GenerateBogusDataButton = new System.Windows.Forms.Button();
            this.BogusNumericUpDown = new MockingPeopleFrontEnd.Controls.SpecialNumericUpDown();
            this.DumpJsonCheckBox = new System.Windows.Forms.CheckBox();
            this.DatabaseExistCheckButton = new System.Windows.Forms.Button();
            this.TablesArePopulatedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BogusNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateNewDatabaseButton
            // 
            this.CreateNewDatabaseButton.Location = new System.Drawing.Point(12, 12);
            this.CreateNewDatabaseButton.Name = "CreateNewDatabaseButton";
            this.CreateNewDatabaseButton.Size = new System.Drawing.Size(156, 23);
            this.CreateNewDatabaseButton.TabIndex = 0;
            this.CreateNewDatabaseButton.Text = "Create new database";
            this.CreateNewDatabaseButton.UseVisualStyleBackColor = true;
            this.CreateNewDatabaseButton.Click += new System.EventHandler(this.CreateNewDatabaseButton_Click);
            // 
            // PopulateDatabaseButton
            // 
            this.PopulateDatabaseButton.Location = new System.Drawing.Point(211, 12);
            this.PopulateDatabaseButton.Name = "PopulateDatabaseButton";
            this.PopulateDatabaseButton.Size = new System.Drawing.Size(156, 23);
            this.PopulateDatabaseButton.TabIndex = 1;
            this.PopulateDatabaseButton.Text = "Populate database";
            this.PopulateDatabaseButton.UseVisualStyleBackColor = true;
            this.PopulateDatabaseButton.Click += new System.EventHandler(this.PopulateDatabaseButton_Click);
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(449, 12);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(156, 23);
            this.ReadButton.TabIndex = 2;
            this.ReadButton.Text = "Read people";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(10, 71);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(595, 384);
            this.textBox1.TabIndex = 3;
            // 
            // GenerateBogusDataButton
            // 
            this.GenerateBogusDataButton.Location = new System.Drawing.Point(12, 483);
            this.GenerateBogusDataButton.Name = "GenerateBogusDataButton";
            this.GenerateBogusDataButton.Size = new System.Drawing.Size(156, 23);
            this.GenerateBogusDataButton.TabIndex = 4;
            this.GenerateBogusDataButton.Text = "Use Bogus";
            this.GenerateBogusDataButton.UseVisualStyleBackColor = true;
            this.GenerateBogusDataButton.Click += new System.EventHandler(this.GenerateBogusDataButton_Click);
            // 
            // BogusNumericUpDown
            // 
            this.BogusNumericUpDown.Location = new System.Drawing.Point(174, 483);
            this.BogusNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.BogusNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BogusNumericUpDown.Name = "BogusNumericUpDown";
            this.BogusNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.BogusNumericUpDown.TabIndex = 5;
            this.BogusNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BogusNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DumpJsonCheckBox
            // 
            this.DumpJsonCheckBox.AutoSize = true;
            this.DumpJsonCheckBox.Location = new System.Drawing.Point(314, 483);
            this.DumpJsonCheckBox.Name = "DumpJsonCheckBox";
            this.DumpJsonCheckBox.Size = new System.Drawing.Size(98, 19);
            this.DumpJsonCheckBox.TabIndex = 6;
            this.DumpJsonCheckBox.Text = "Dump as json";
            this.DumpJsonCheckBox.UseVisualStyleBackColor = true;
            // 
            // DatabaseExistCheckButton
            // 
            this.DatabaseExistCheckButton.Location = new System.Drawing.Point(12, 522);
            this.DatabaseExistCheckButton.Name = "DatabaseExistCheckButton";
            this.DatabaseExistCheckButton.Size = new System.Drawing.Size(156, 23);
            this.DatabaseExistCheckButton.TabIndex = 7;
            this.DatabaseExistCheckButton.Text = "Database exits";
            this.DatabaseExistCheckButton.UseVisualStyleBackColor = true;
            this.DatabaseExistCheckButton.Click += new System.EventHandler(this.DatabaseExistCheckButton_Click);
            // 
            // TablesArePopulatedButton
            // 
            this.TablesArePopulatedButton.Location = new System.Drawing.Point(12, 551);
            this.TablesArePopulatedButton.Name = "TablesArePopulatedButton";
            this.TablesArePopulatedButton.Size = new System.Drawing.Size(156, 23);
            this.TablesArePopulatedButton.TabIndex = 8;
            this.TablesArePopulatedButton.Text = "Tables are populated";
            this.TablesArePopulatedButton.UseVisualStyleBackColor = true;
            this.TablesArePopulatedButton.Click += new System.EventHandler(this.TablesArePopulatedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 586);
            this.Controls.Add(this.TablesArePopulatedButton);
            this.Controls.Add(this.DatabaseExistCheckButton);
            this.Controls.Add(this.DumpJsonCheckBox);
            this.Controls.Add(this.BogusNumericUpDown);
            this.Controls.Add(this.GenerateBogusDataButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.PopulateDatabaseButton);
            this.Controls.Add(this.CreateNewDatabaseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "People data";
            ((System.ComponentModel.ISupportInitialize)(this.BogusNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateNewDatabaseButton;
        private System.Windows.Forms.Button PopulateDatabaseButton;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GenerateBogusDataButton;
        private Controls.SpecialNumericUpDown BogusNumericUpDown;
        private System.Windows.Forms.CheckBox DumpJsonCheckBox;
        private System.Windows.Forms.Button DatabaseExistCheckButton;
        private System.Windows.Forms.Button TablesArePopulatedButton;
    }
}

