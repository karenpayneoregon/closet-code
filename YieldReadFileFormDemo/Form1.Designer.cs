
namespace YieldReadFileFormDemo
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.YieldButton = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.ExpressionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // YieldButton
            // 
            this.YieldButton.Location = new System.Drawing.Point(22, 132);
            this.YieldButton.Name = "YieldButton";
            this.YieldButton.Size = new System.Drawing.Size(120, 23);
            this.YieldButton.TabIndex = 1;
            this.YieldButton.Text = "Yield";
            this.YieldButton.UseVisualStyleBackColor = true;
            this.YieldButton.Click += new System.EventHandler(this.YieldButton_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(170, 31);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 2;
            // 
            // ExpressionButton
            // 
            this.ExpressionButton.Location = new System.Drawing.Point(170, 132);
            this.ExpressionButton.Name = "ExpressionButton";
            this.ExpressionButton.Size = new System.Drawing.Size(120, 23);
            this.ExpressionButton.TabIndex = 3;
            this.ExpressionButton.Text = "Expression";
            this.ExpressionButton.UseVisualStyleBackColor = true;
            this.ExpressionButton.Click += new System.EventHandler(this.ExpressionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 230);
            this.Controls.Add(this.ExpressionButton);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.YieldButton);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button YieldButton;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button ExpressionButton;
    }
}

