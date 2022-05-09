
namespace NLogForms1
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
            this.ExecuteMethodButton = new System.Windows.Forms.Button();
            this.WorkerMethodButton = new System.Windows.Forms.Button();
            this.FinderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExecuteMethodButton
            // 
            this.ExecuteMethodButton.Location = new System.Drawing.Point(12, 12);
            this.ExecuteMethodButton.Name = "ExecuteMethodButton";
            this.ExecuteMethodButton.Size = new System.Drawing.Size(219, 23);
            this.ExecuteMethodButton.TabIndex = 0;
            this.ExecuteMethodButton.Text = "Execute method ";
            this.ExecuteMethodButton.UseVisualStyleBackColor = true;
            this.ExecuteMethodButton.Click += new System.EventHandler(this.ExecuteMethodButton_Click);
            // 
            // WorkerMethodButton
            // 
            this.WorkerMethodButton.Location = new System.Drawing.Point(12, 51);
            this.WorkerMethodButton.Name = "WorkerMethodButton";
            this.WorkerMethodButton.Size = new System.Drawing.Size(219, 23);
            this.WorkerMethodButton.TabIndex = 1;
            this.WorkerMethodButton.Text = "Worker method";
            this.WorkerMethodButton.UseVisualStyleBackColor = true;
            this.WorkerMethodButton.Click += new System.EventHandler(this.WorkerMethodButton_Click);
            // 
            // FinderButton
            // 
            this.FinderButton.Location = new System.Drawing.Point(12, 90);
            this.FinderButton.Name = "FinderButton";
            this.FinderButton.Size = new System.Drawing.Size(219, 23);
            this.FinderButton.TabIndex = 2;
            this.FinderButton.Text = "Finder";
            this.FinderButton.UseVisualStyleBackColor = true;
            this.FinderButton.Click += new System.EventHandler(this.FinderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 125);
            this.Controls.Add(this.FinderButton);
            this.Controls.Add(this.WorkerMethodButton);
            this.Controls.Add(this.ExecuteMethodButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NLog demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExecuteMethodButton;
        private System.Windows.Forms.Button WorkerMethodButton;
        private System.Windows.Forms.Button FinderButton;
    }
}

