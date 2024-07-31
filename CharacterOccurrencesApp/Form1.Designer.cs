
namespace CharacterOccurrencesApp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.GetFromTextBoxsTextBox = new System.Windows.Forms.Button();
            this.ReadFromFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(671, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "8257,5321,0181,8279,8661,2120,6641,4000,0752,6975,9849,9106,7661,4522,4287,8613,3" +
    "279,6296,4498,6003,8273,6642,5201";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(12, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(671, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "6235,5507,0126,9753,0354,0423,0328,6185,8449,3424,1481,1861,3234,5928,3503,1966,0" +
    "513,2306,2315,3750,0190,1510,006";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(227, 98);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(213, 231);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(470, 98);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(213, 231);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Item";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Count";
            // 
            // GetFromTextBoxsTextBox
            // 
            this.GetFromTextBoxsTextBox.Location = new System.Drawing.Point(12, 98);
            this.GetFromTextBoxsTextBox.Name = "GetFromTextBoxsTextBox";
            this.GetFromTextBoxsTextBox.Size = new System.Drawing.Size(174, 23);
            this.GetFromTextBoxsTextBox.TabIndex = 4;
            this.GetFromTextBoxsTextBox.Text = "Get from Textboxes";
            this.GetFromTextBoxsTextBox.UseVisualStyleBackColor = true;
            this.GetFromTextBoxsTextBox.Click += new System.EventHandler(this.GetFromTextBoxesTextBox_Click);
            // 
            // ReadFromFileButton
            // 
            this.ReadFromFileButton.Location = new System.Drawing.Point(12, 136);
            this.ReadFromFileButton.Name = "ReadFromFileButton";
            this.ReadFromFileButton.Size = new System.Drawing.Size(174, 23);
            this.ReadFromFileButton.TabIndex = 5;
            this.ReadFromFileButton.Text = "Read from file";
            this.ReadFromFileButton.UseVisualStyleBackColor = true;
            this.ReadFromFileButton.Click += new System.EventHandler(this.ReadFromFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.ReadFromFileButton);
            this.Controls.Add(this.GetFromTextBoxsTextBox);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Occurrences code sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button GetFromTextBoxsTextBox;
        private System.Windows.Forms.Button ReadFromFileButton;
    }
}

