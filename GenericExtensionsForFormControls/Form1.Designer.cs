
namespace GenericExtensionsForFormControls
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
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.ProductListBox = new System.Windows.Forms.ListBox();
            this.CurrentCategoryIBaseButton = new System.Windows.Forms.Button();
            this.CurrentCategoryGenericButton = new System.Windows.Forms.Button();
            this.CurrentCategoryCommonButton = new System.Windows.Forms.Button();
            this.ProductCommonButton = new System.Windows.Forms.Button();
            this.CurrentProductGeneric = new System.Windows.Forms.Button();
            this.CurrentProductIBaseButton = new System.Windows.Forms.Button();
            this.ProductsCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.GetCheckedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.ItemHeight = 15;
            this.CategoryListBox.Location = new System.Drawing.Point(12, 12);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(171, 154);
            this.CategoryListBox.TabIndex = 0;
            // 
            // ProductListBox
            // 
            this.ProductListBox.FormattingEnabled = true;
            this.ProductListBox.ItemHeight = 15;
            this.ProductListBox.Location = new System.Drawing.Point(235, 12);
            this.ProductListBox.Name = "ProductListBox";
            this.ProductListBox.Size = new System.Drawing.Size(171, 154);
            this.ProductListBox.TabIndex = 1;
            // 
            // CurrentCategoryIBaseButton
            // 
            this.CurrentCategoryIBaseButton.Location = new System.Drawing.Point(12, 172);
            this.CurrentCategoryIBaseButton.Name = "CurrentCategoryIBaseButton";
            this.CurrentCategoryIBaseButton.Size = new System.Drawing.Size(171, 23);
            this.CurrentCategoryIBaseButton.TabIndex = 2;
            this.CurrentCategoryIBaseButton.Text = "Current Category (IBase)";
            this.CurrentCategoryIBaseButton.UseVisualStyleBackColor = true;
            this.CurrentCategoryIBaseButton.Click += new System.EventHandler(this.CurrentCategoryIBaseButton_Click);
            // 
            // CurrentCategoryGenericButton
            // 
            this.CurrentCategoryGenericButton.Location = new System.Drawing.Point(12, 201);
            this.CurrentCategoryGenericButton.Name = "CurrentCategoryGenericButton";
            this.CurrentCategoryGenericButton.Size = new System.Drawing.Size(171, 23);
            this.CurrentCategoryGenericButton.TabIndex = 3;
            this.CurrentCategoryGenericButton.Text = "Current Category (Generic)";
            this.CurrentCategoryGenericButton.UseVisualStyleBackColor = true;
            this.CurrentCategoryGenericButton.Click += new System.EventHandler(this.CurrentCategoryGenericButton_Click);
            // 
            // CurrentCategoryCommonButton
            // 
            this.CurrentCategoryCommonButton.Location = new System.Drawing.Point(12, 233);
            this.CurrentCategoryCommonButton.Name = "CurrentCategoryCommonButton";
            this.CurrentCategoryCommonButton.Size = new System.Drawing.Size(171, 23);
            this.CurrentCategoryCommonButton.TabIndex = 4;
            this.CurrentCategoryCommonButton.Text = "Current Category (Common)";
            this.CurrentCategoryCommonButton.UseVisualStyleBackColor = true;
            this.CurrentCategoryCommonButton.Click += new System.EventHandler(this.CurrentCategoryCommonButton_Click);
            // 
            // ProductCommonButton
            // 
            this.ProductCommonButton.Location = new System.Drawing.Point(235, 233);
            this.ProductCommonButton.Name = "ProductCommonButton";
            this.ProductCommonButton.Size = new System.Drawing.Size(171, 23);
            this.ProductCommonButton.TabIndex = 7;
            this.ProductCommonButton.Text = "Current Product (Common)";
            this.ProductCommonButton.UseVisualStyleBackColor = true;
            this.ProductCommonButton.Click += new System.EventHandler(this.ProductCommonButton_Click);
            // 
            // CurrentProductGeneric
            // 
            this.CurrentProductGeneric.Location = new System.Drawing.Point(235, 201);
            this.CurrentProductGeneric.Name = "CurrentProductGeneric";
            this.CurrentProductGeneric.Size = new System.Drawing.Size(171, 23);
            this.CurrentProductGeneric.TabIndex = 6;
            this.CurrentProductGeneric.Text = "Current Product (Generic)";
            this.CurrentProductGeneric.UseVisualStyleBackColor = true;
            this.CurrentProductGeneric.Click += new System.EventHandler(this.CurrentProductGeneric_Click);
            // 
            // CurrentProductIBaseButton
            // 
            this.CurrentProductIBaseButton.Location = new System.Drawing.Point(235, 172);
            this.CurrentProductIBaseButton.Name = "CurrentProductIBaseButton";
            this.CurrentProductIBaseButton.Size = new System.Drawing.Size(171, 23);
            this.CurrentProductIBaseButton.TabIndex = 5;
            this.CurrentProductIBaseButton.Text = "Current Product (IBase)";
            this.CurrentProductIBaseButton.UseVisualStyleBackColor = true;
            this.CurrentProductIBaseButton.Click += new System.EventHandler(this.CurrentProductIBaseButton_Click);
            // 
            // ProductsCheckListBox
            // 
            this.ProductsCheckListBox.FormattingEnabled = true;
            this.ProductsCheckListBox.Location = new System.Drawing.Point(421, 12);
            this.ProductsCheckListBox.Name = "ProductsCheckListBox";
            this.ProductsCheckListBox.Size = new System.Drawing.Size(171, 148);
            this.ProductsCheckListBox.TabIndex = 8;
            // 
            // GetCheckedButton
            // 
            this.GetCheckedButton.Location = new System.Drawing.Point(421, 172);
            this.GetCheckedButton.Name = "GetCheckedButton";
            this.GetCheckedButton.Size = new System.Drawing.Size(171, 23);
            this.GetCheckedButton.TabIndex = 9;
            this.GetCheckedButton.Text = "Get Checked";
            this.GetCheckedButton.UseVisualStyleBackColor = true;
            this.GetCheckedButton.Click += new System.EventHandler(this.GetCheckedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 268);
            this.Controls.Add(this.GetCheckedButton);
            this.Controls.Add(this.ProductsCheckListBox);
            this.Controls.Add(this.ProductCommonButton);
            this.Controls.Add(this.CurrentProductGeneric);
            this.Controls.Add(this.CurrentProductIBaseButton);
            this.Controls.Add(this.CurrentCategoryCommonButton);
            this.Controls.Add(this.CurrentCategoryGenericButton);
            this.Controls.Add(this.CurrentCategoryIBaseButton);
            this.Controls.Add(this.ProductListBox);
            this.Controls.Add(this.CategoryListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CategoryListBox;
        private System.Windows.Forms.ListBox ProductListBox;
        private System.Windows.Forms.Button CurrentCategoryIBaseButton;
        private System.Windows.Forms.Button CurrentCategoryGenericButton;
        private System.Windows.Forms.Button CurrentCategoryCommonButton;
        private System.Windows.Forms.Button ProductCommonButton;
        private System.Windows.Forms.Button CurrentProductGeneric;
        private System.Windows.Forms.Button CurrentProductIBaseButton;
        private System.Windows.Forms.CheckedListBox ProductsCheckListBox;
        private System.Windows.Forms.Button GetCheckedButton;
    }
}

