namespace ForumQuestion1
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
            this.CreateJsonFileButton = new System.Windows.Forms.Button();
            this.ReadJustCreatedFileButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.GetSelectedButton = new System.Windows.Forms.Button();
            this.TryAddNewButton = new System.Windows.Forms.Button();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateJsonFileButton
            // 
            this.CreateJsonFileButton.Location = new System.Drawing.Point(65, 28);
            this.CreateJsonFileButton.Name = "CreateJsonFileButton";
            this.CreateJsonFileButton.Size = new System.Drawing.Size(247, 29);
            this.CreateJsonFileButton.TabIndex = 0;
            this.CreateJsonFileButton.Text = "Create mocked json file";
            this.CreateJsonFileButton.UseVisualStyleBackColor = true;
            this.CreateJsonFileButton.Click += new System.EventHandler(this.CreateJsonFileButton_Click);
            // 
            // ReadJustCreatedFileButton
            // 
            this.ReadJustCreatedFileButton.Location = new System.Drawing.Point(65, 75);
            this.ReadJustCreatedFileButton.Name = "ReadJustCreatedFileButton";
            this.ReadJustCreatedFileButton.Size = new System.Drawing.Size(247, 29);
            this.ReadJustCreatedFileButton.TabIndex = 1;
            this.ReadJustCreatedFileButton.Text = "Read just created json file";
            this.ReadJustCreatedFileButton.UseVisualStyleBackColor = true;
            this.ReadJustCreatedFileButton.Click += new System.EventHandler(this.ReadJustCreatedFileButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(333, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 104);
            this.listBox1.TabIndex = 2;
            // 
            // AddNewButton
            // 
            this.AddNewButton.Location = new System.Drawing.Point(65, 120);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(247, 29);
            this.AddNewButton.TabIndex = 3;
            this.AddNewButton.Text = "Add new";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // GetSelectedButton
            // 
            this.GetSelectedButton.Location = new System.Drawing.Point(333, 138);
            this.GetSelectedButton.Name = "GetSelectedButton";
            this.GetSelectedButton.Size = new System.Drawing.Size(330, 29);
            this.GetSelectedButton.TabIndex = 4;
            this.GetSelectedButton.Text = "Get selected";
            this.GetSelectedButton.UseVisualStyleBackColor = true;
            this.GetSelectedButton.Click += new System.EventHandler(this.GetSelectedButton_Click);
            // 
            // TryAddNewButton
            // 
            this.TryAddNewButton.Location = new System.Drawing.Point(65, 208);
            this.TryAddNewButton.Name = "TryAddNewButton";
            this.TryAddNewButton.Size = new System.Drawing.Size(247, 29);
            this.TryAddNewButton.TabIndex = 5;
            this.TryAddNewButton.Text = "Try Add new";
            this.TryAddNewButton.UseVisualStyleBackColor = true;
            this.TryAddNewButton.Click += new System.EventHandler(this.TryAddNewButton_Click);
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Location = new System.Drawing.Point(333, 208);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(330, 27);
            this.CompanyNameTextBox.TabIndex = 6;
            this.CompanyNameTextBox.Text = "Microsoft";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(65, 263);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(247, 29);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ForumQuestion1.Properties.Resources.One;
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 37);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 37);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 319);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CompanyNameTextBox);
            this.Controls.Add(this.TryAddNewButton);
            this.Controls.Add(this.GetSelectedButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ReadJustCreatedFileButton);
            this.Controls.Add(this.CreateJsonFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CreateJsonFileButton;
        private Button ReadJustCreatedFileButton;
        private ListBox listBox1;
        private Button AddNewButton;
        private Button GetSelectedButton;
        private Button TryAddNewButton;
        private TextBox CompanyNameTextBox;
        private Button SaveButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}