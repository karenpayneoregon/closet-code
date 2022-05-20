
namespace RemoveMarkOfWeb
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
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.ShowHelpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.AllowDrop = true;
            this.FolderTextBox.Location = new System.Drawing.Point(12, 12);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.Size = new System.Drawing.Size(483, 20);
            this.FolderTextBox.TabIndex = 1;
            this.FolderTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.FolderTextBox_DragDrop);
            this.FolderTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.FolderTextBox_DragEnter);
            this.FolderTextBox.DragLeave += new System.EventHandler(this.FolderTextBox_DragLeave);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Image = global::RemoveMarkOfWeb.Properties.Resources.Run;
            this.ExecuteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExecuteButton.Location = new System.Drawing.Point(12, 47);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(91, 23);
            this.ExecuteButton.TabIndex = 0;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // ShowHelpLabel
            // 
            this.ShowHelpLabel.AutoSize = true;
            this.ShowHelpLabel.BackColor = System.Drawing.SystemColors.Window;
            this.ShowHelpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowHelpLabel.Location = new System.Drawing.Point(169, 15);
            this.ShowHelpLabel.Name = "ShowHelpLabel";
            this.ShowHelpLabel.Size = new System.Drawing.Size(99, 13);
            this.ShowHelpLabel.TabIndex = 2;
            this.ShowHelpLabel.Text = "Drop folder here";
            this.ShowHelpLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 88);
            this.Controls.Add(this.ShowHelpLabel);
            this.Controls.Add(this.FolderTextBox);
            this.Controls.Add(this.ExecuteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove mark of the web - by Karen Payne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.Label ShowHelpLabel;
    }
}

