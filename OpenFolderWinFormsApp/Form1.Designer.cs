namespace OpenFolderWinFormsApp
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
            this.IsCoreButton = new System.Windows.Forms.Button();
            this.IsCoreCheckBox = new System.Windows.Forms.CheckBox();
            this.OpenFolderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IsCoreButton
            // 
            this.IsCoreButton.Location = new System.Drawing.Point(12, 12);
            this.IsCoreButton.Name = "IsCoreButton";
            this.IsCoreButton.Size = new System.Drawing.Size(75, 23);
            this.IsCoreButton.TabIndex = 0;
            this.IsCoreButton.Text = "Is Core";
            this.IsCoreButton.UseVisualStyleBackColor = true;
            this.IsCoreButton.Click += new System.EventHandler(this.IsCoreButton_Click);
            // 
            // IsCoreCheckBox
            // 
            this.IsCoreCheckBox.AutoSize = true;
            this.IsCoreCheckBox.Location = new System.Drawing.Point(93, 16);
            this.IsCoreCheckBox.Name = "IsCoreCheckBox";
            this.IsCoreCheckBox.Size = new System.Drawing.Size(15, 14);
            this.IsCoreCheckBox.TabIndex = 1;
            this.IsCoreCheckBox.UseVisualStyleBackColor = true;
            // 
            // OpenFolderButton
            // 
            this.OpenFolderButton.Location = new System.Drawing.Point(12, 41);
            this.OpenFolderButton.Name = "OpenFolderButton";
            this.OpenFolderButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFolderButton.TabIndex = 2;
            this.OpenFolderButton.Text = "Open Dir";
            this.OpenFolderButton.UseVisualStyleBackColor = true;
            this.OpenFolderButton.Click += new System.EventHandler(this.OpenFolderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 164);
            this.Controls.Add(this.OpenFolderButton);
            this.Controls.Add(this.IsCoreCheckBox);
            this.Controls.Add(this.IsCoreButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button IsCoreButton;
        private CheckBox IsCoreCheckBox;
        private Button OpenFolderButton;
    }
}