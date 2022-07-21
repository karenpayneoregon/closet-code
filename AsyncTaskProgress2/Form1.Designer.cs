
namespace AsyncTaskProgress2
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
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.CancellButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(29, 91);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(158, 20);
            this.TextBox1.TabIndex = 7;
            // 
            // CancellButton
            // 
            this.CancellButton.Location = new System.Drawing.Point(112, 52);
            this.CancellButton.Name = "CancellButton";
            this.CancellButton.Size = new System.Drawing.Size(75, 23);
            this.CancellButton.TabIndex = 6;
            this.CancellButton.Text = "Cancel";
            this.CancellButton.UseVisualStyleBackColor = true;
            this.CancellButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(31, 52);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(28, 22);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(98, 13);
            this.StatusLabel.TabIndex = 4;
            this.StatusLabel.Text = "Status place holder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 155);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.CancellButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StatusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Button CancellButton;
        internal System.Windows.Forms.Button StartButton;
        internal System.Windows.Forms.Label StatusLabel;
    }
}

