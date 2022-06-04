
namespace ValidatingFormProject
{
    partial class SideForm
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
            this.ErrorsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ErrorsTextBox
            // 
            this.ErrorsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorsTextBox.Location = new System.Drawing.Point(0, 0);
            this.ErrorsTextBox.Multiline = true;
            this.ErrorsTextBox.Name = "ErrorsTextBox";
            this.ErrorsTextBox.Size = new System.Drawing.Size(430, 192);
            this.ErrorsTextBox.TabIndex = 0;
            // 
            // SideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 192);
            this.Controls.Add(this.ErrorsTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SideForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox ErrorsTextBox;
    }
}