
namespace DataBindValidate
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
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.ValidateButton = new System.Windows.Forms.Button();
            this.SetSettingToNullButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(12, 24);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberTextBox.TabIndex = 0;
            // 
            // ValidateButton
            // 
            this.ValidateButton.Location = new System.Drawing.Point(13, 65);
            this.ValidateButton.Name = "ValidateButton";
            this.ValidateButton.Size = new System.Drawing.Size(75, 23);
            this.ValidateButton.TabIndex = 1;
            this.ValidateButton.Text = "Validate";
            this.ValidateButton.UseVisualStyleBackColor = true;
            this.ValidateButton.Click += new System.EventHandler(this.ValidateButton_Click);
            // 
            // SetSettingToNullButton
            // 
            this.SetSettingToNullButton.Location = new System.Drawing.Point(172, 65);
            this.SetSettingToNullButton.Name = "SetSettingToNullButton";
            this.SetSettingToNullButton.Size = new System.Drawing.Size(75, 23);
            this.SetSettingToNullButton.TabIndex = 2;
            this.SetSettingToNullButton.Text = "null setting";
            this.SetSettingToNullButton.UseVisualStyleBackColor = true;
            this.SetSettingToNullButton.Click += new System.EventHandler(this.SetSettingToNullButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 143);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SetSettingToNullButton);
            this.Controls.Add(this.ValidateButton);
            this.Controls.Add(this.NumberTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Button ValidateButton;
        private System.Windows.Forms.Button SetSettingToNullButton;
        private System.Windows.Forms.Button button1;
    }
}

