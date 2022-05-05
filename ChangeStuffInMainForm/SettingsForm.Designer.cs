
namespace ChangeStuffInMainForm
{
    partial class SettingsForm
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.FormBackColorButton = new System.Windows.Forms.Button();
            this.PanelBackColor = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BindingExampleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormBackColorButton
            // 
            this.FormBackColorButton.Location = new System.Drawing.Point(12, 12);
            this.FormBackColorButton.Name = "FormBackColorButton";
            this.FormBackColorButton.Size = new System.Drawing.Size(108, 23);
            this.FormBackColorButton.TabIndex = 0;
            this.FormBackColorButton.Text = "Form back color";
            this.FormBackColorButton.UseVisualStyleBackColor = true;
            this.FormBackColorButton.Click += new System.EventHandler(this.FormBackColorButton_Click);
            // 
            // PanelBackColor
            // 
            this.PanelBackColor.Location = new System.Drawing.Point(137, 12);
            this.PanelBackColor.Name = "PanelBackColor";
            this.PanelBackColor.Size = new System.Drawing.Size(108, 23);
            this.PanelBackColor.TabIndex = 1;
            this.PanelBackColor.Text = "Panel back color";
            this.PanelBackColor.UseVisualStyleBackColor = true;
            this.PanelBackColor.Click += new System.EventHandler(this.PanelBackColor_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 41);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(108, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BindingExampleButton
            // 
            this.BindingExampleButton.Location = new System.Drawing.Point(137, 41);
            this.BindingExampleButton.Name = "BindingExampleButton";
            this.BindingExampleButton.Size = new System.Drawing.Size(108, 23);
            this.BindingExampleButton.TabIndex = 3;
            this.BindingExampleButton.Text = "Binding";
            this.BindingExampleButton.UseVisualStyleBackColor = true;
            this.BindingExampleButton.Click += new System.EventHandler(this.BindingExampleButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 91);
            this.Controls.Add(this.BindingExampleButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PanelBackColor);
            this.Controls.Add(this.FormBackColorButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button FormBackColorButton;
        private System.Windows.Forms.Button PanelBackColor;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button BindingExampleButton;
    }
}