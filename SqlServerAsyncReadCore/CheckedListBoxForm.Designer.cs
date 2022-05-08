
namespace SqlServerAsyncReadCore
{
    partial class CheckedListBoxForm
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
            this.ProductCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.GetCheckedButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GetCheckedProductsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductCheckedListBox
            // 
            this.ProductCheckedListBox.FormattingEnabled = true;
            this.ProductCheckedListBox.Location = new System.Drawing.Point(12, 26);
            this.ProductCheckedListBox.Name = "ProductCheckedListBox";
            this.ProductCheckedListBox.Size = new System.Drawing.Size(263, 220);
            this.ProductCheckedListBox.TabIndex = 0;
            // 
            // GetCheckedButton
            // 
            this.GetCheckedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetCheckedButton.Enabled = false;
            this.GetCheckedButton.Location = new System.Drawing.Point(295, 26);
            this.GetCheckedButton.Name = "GetCheckedButton";
            this.GetCheckedButton.Size = new System.Drawing.Size(263, 23);
            this.GetCheckedButton.TabIndex = 1;
            this.GetCheckedButton.Text = "Get checked raw";
            this.GetCheckedButton.UseVisualStyleBackColor = true;
            this.GetCheckedButton.Click += new System.EventHandler(this.GetCheckedButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 265);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(542, 144);
            this.textBox1.TabIndex = 2;
            // 
            // GetCheckedProductsButton
            // 
            this.GetCheckedProductsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetCheckedProductsButton.Enabled = false;
            this.GetCheckedProductsButton.Location = new System.Drawing.Point(295, 55);
            this.GetCheckedProductsButton.Name = "GetCheckedProductsButton";
            this.GetCheckedProductsButton.Size = new System.Drawing.Size(263, 23);
            this.GetCheckedProductsButton.TabIndex = 3;
            this.GetCheckedProductsButton.Text = "Get checked Products";
            this.GetCheckedProductsButton.UseVisualStyleBackColor = true;
            this.GetCheckedProductsButton.Click += new System.EventHandler(this.GetCheckedProductsButton_Click);
            // 
            // CheckedListBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 432);
            this.Controls.Add(this.GetCheckedProductsButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GetCheckedButton);
            this.Controls.Add(this.ProductCheckedListBox);
            this.Name = "CheckedListBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get checked items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ProductCheckedListBox;
        private System.Windows.Forms.Button GetCheckedButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GetCheckedProductsButton;
    }
}