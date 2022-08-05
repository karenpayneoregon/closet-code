
namespace CreateDynamicControls
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
            this.CreateButton = new System.Windows.Forms.Button();
            this.ButtonListButton = new System.Windows.Forms.Button();
            this.ButtonsListBox = new System.Windows.Forms.ListBox();
            this.ButtonTextButton = new System.Windows.Forms.TextBox();
            this.CreateCategoriesButton = new System.Windows.Forms.Button();
            this.ProductsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(311, 225);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(120, 23);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "Create button";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButtonClick);
            // 
            // ButtonListButton
            // 
            this.ButtonListButton.Location = new System.Drawing.Point(311, 196);
            this.ButtonListButton.Name = "ButtonListButton";
            this.ButtonListButton.Size = new System.Drawing.Size(120, 23);
            this.ButtonListButton.TabIndex = 1;
            this.ButtonListButton.Text = "List buttons";
            this.ButtonListButton.UseVisualStyleBackColor = true;
            this.ButtonListButton.Click += new System.EventHandler(this.ButtonListButton_Click);
            // 
            // ButtonsListBox
            // 
            this.ButtonsListBox.FormattingEnabled = true;
            this.ButtonsListBox.Location = new System.Drawing.Point(311, 17);
            this.ButtonsListBox.Name = "ButtonsListBox";
            this.ButtonsListBox.Size = new System.Drawing.Size(120, 173);
            this.ButtonsListBox.TabIndex = 2;
            // 
            // ButtonTextButton
            // 
            this.ButtonTextButton.Location = new System.Drawing.Point(311, 254);
            this.ButtonTextButton.Name = "ButtonTextButton";
            this.ButtonTextButton.Size = new System.Drawing.Size(120, 20);
            this.ButtonTextButton.TabIndex = 3;
            // 
            // CreateCategoriesButton
            // 
            this.CreateCategoriesButton.Location = new System.Drawing.Point(311, 290);
            this.CreateCategoriesButton.Name = "CreateCategoriesButton";
            this.CreateCategoriesButton.Size = new System.Drawing.Size(120, 23);
            this.CreateCategoriesButton.TabIndex = 4;
            this.CreateCategoriesButton.Text = "Create buttons";
            this.CreateCategoriesButton.UseVisualStyleBackColor = true;
            this.CreateCategoriesButton.Click += new System.EventHandler(this.CreateCategoriesButton_Click);
            // 
            // ProductsListBox
            // 
            this.ProductsListBox.FormattingEnabled = true;
            this.ProductsListBox.Location = new System.Drawing.Point(136, 18);
            this.ProductsListBox.Name = "ProductsListBox";
            this.ProductsListBox.Size = new System.Drawing.Size(164, 290);
            this.ProductsListBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(452, 345);
            this.Controls.Add(this.ProductsListBox);
            this.Controls.Add(this.CreateCategoriesButton);
            this.Controls.Add(this.ButtonTextButton);
            this.Controls.Add(this.ButtonsListBox);
            this.Controls.Add(this.ButtonListButton);
            this.Controls.Add(this.CreateButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Dynamic button";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button ButtonListButton;
        private System.Windows.Forms.ListBox ButtonsListBox;
        private System.Windows.Forms.TextBox ButtonTextButton;
        private System.Windows.Forms.Button CreateCategoriesButton;
        private System.Windows.Forms.ListBox ProductsListBox;
    }
}

