﻿
namespace PassStringFromChildToParentForm
{
    partial class MainForm
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
            this.ShowChildForm = new System.Windows.Forms.Button();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.DummyButtton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowChildForm
            // 
            this.ShowChildForm.Location = new System.Drawing.Point(12, 81);
            this.ShowChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.ShowChildForm.Name = "ShowChildForm";
            this.ShowChildForm.Size = new System.Drawing.Size(320, 28);
            this.ShowChildForm.TabIndex = 1;
            this.ShowChildForm.Text = "Show";
            this.ShowChildForm.UseVisualStyleBackColor = true;
            this.ShowChildForm.Click += new System.EventHandler(this.ShowChildForm_Click);
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(13, 38);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(77, 20);
            this.FemaleRadioButton.TabIndex = 7;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Femaile";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(12, 12);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(58, 20);
            this.MaleRadioButton.TabIndex = 6;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // DummyButtton
            // 
            this.DummyButtton.Location = new System.Drawing.Point(14, 117);
            this.DummyButtton.Margin = new System.Windows.Forms.Padding(4);
            this.DummyButtton.Name = "DummyButtton";
            this.DummyButtton.Size = new System.Drawing.Size(320, 28);
            this.DummyButtton.TabIndex = 8;
            this.DummyButtton.Text = "Dummy";
            this.DummyButtton.UseVisualStyleBackColor = true;
            this.DummyButtton.Click += new System.EventHandler(this.DummyButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 223);
            this.Controls.Add(this.DummyButtton);
            this.Controls.Add(this.FemaleRadioButton);
            this.Controls.Add(this.MaleRadioButton);
            this.Controls.Add(this.ShowChildForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ShowChildForm;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.Button DummyButtton;
    }
}

