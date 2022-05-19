
namespace RecursivePatterns
{
    partial class MainForm
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
            this.Example1Button = new System.Windows.Forms.Button();
            this.Example2Button = new System.Windows.Forms.Button();
            this.Example3Button = new System.Windows.Forms.Button();
            this.Example4Button = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.ValidBirthYearButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Example1Button
            // 
            this.Example1Button.Location = new System.Drawing.Point(11, 24);
            this.Example1Button.Name = "Example1Button";
            this.Example1Button.Size = new System.Drawing.Size(98, 23);
            this.Example1Button.TabIndex = 0;
            this.Example1Button.Text = "Example 1";
            this.Example1Button.UseVisualStyleBackColor = true;
            this.Example1Button.Click += new System.EventHandler(this.Example1Button_Click);
            // 
            // Example2Button
            // 
            this.Example2Button.Location = new System.Drawing.Point(12, 53);
            this.Example2Button.Name = "Example2Button";
            this.Example2Button.Size = new System.Drawing.Size(98, 23);
            this.Example2Button.TabIndex = 1;
            this.Example2Button.Text = "Example 2";
            this.Example2Button.UseVisualStyleBackColor = true;
            this.Example2Button.Click += new System.EventHandler(this.Example2Button_Click);
            // 
            // Example3Button
            // 
            this.Example3Button.Location = new System.Drawing.Point(12, 82);
            this.Example3Button.Name = "Example3Button";
            this.Example3Button.Size = new System.Drawing.Size(98, 23);
            this.Example3Button.TabIndex = 2;
            this.Example3Button.Text = "Example 3";
            this.Example3Button.UseVisualStyleBackColor = true;
            this.Example3Button.Click += new System.EventHandler(this.Example3Button_Click);
            // 
            // Example4Button
            // 
            this.Example4Button.Location = new System.Drawing.Point(12, 111);
            this.Example4Button.Name = "Example4Button";
            this.Example4Button.Size = new System.Drawing.Size(98, 23);
            this.Example4Button.TabIndex = 3;
            this.Example4Button.Text = "Example 4";
            this.Example4Button.UseVisualStyleBackColor = true;
            this.Example4Button.Click += new System.EventHandler(this.Example4Button_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultsTextBox.Location = new System.Drawing.Point(126, 23);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultsTextBox.Size = new System.Drawing.Size(343, 187);
            this.ResultsTextBox.TabIndex = 4;
            // 
            // ValidBirthYearButton
            // 
            this.ValidBirthYearButton.Location = new System.Drawing.Point(12, 234);
            this.ValidBirthYearButton.Name = "ValidBirthYearButton";
            this.ValidBirthYearButton.Size = new System.Drawing.Size(176, 23);
            this.ValidBirthYearButton.TabIndex = 5;
            this.ValidBirthYearButton.Text = "Valid birth year";
            this.ValidBirthYearButton.UseVisualStyleBackColor = true;
            this.ValidBirthYearButton.Click += new System.EventHandler(this.ValidBirthYearButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "if (a is \"bcd\" or \"efg\")";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ValidBirthYearButton);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.Example4Button);
            this.Controls.Add(this.Example3Button);
            this.Controls.Add(this.Example2Button);
            this.Controls.Add(this.Example1Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recursive patterns code sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Example1Button;
        private System.Windows.Forms.Button Example2Button;
        private System.Windows.Forms.Button Example3Button;
        private System.Windows.Forms.Button Example4Button;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Button ValidBirthYearButton;
        private System.Windows.Forms.Button button1;
    }
}

