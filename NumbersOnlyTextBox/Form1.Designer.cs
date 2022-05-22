
namespace NumbersOnlyTextBox
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GetValueButton = new System.Windows.Forms.Button();
            this.NumericUpDownValueButton = new System.Windows.Forms.Button();
            this.specialNumericUpDown1 = new NumbersOnlyTextBox.SpecialNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.specialNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // GetValueButton
            // 
            this.GetValueButton.Location = new System.Drawing.Point(137, 9);
            this.GetValueButton.Name = "GetValueButton";
            this.GetValueButton.Size = new System.Drawing.Size(75, 23);
            this.GetValueButton.TabIndex = 1;
            this.GetValueButton.Text = "Get value";
            this.GetValueButton.UseVisualStyleBackColor = true;
            this.GetValueButton.Click += new System.EventHandler(this.GetValueButton_Click);
            // 
            // NumericUpDownValueButton
            // 
            this.NumericUpDownValueButton.Location = new System.Drawing.Point(137, 38);
            this.NumericUpDownValueButton.Name = "NumericUpDownValueButton";
            this.NumericUpDownValueButton.Size = new System.Drawing.Size(75, 23);
            this.NumericUpDownValueButton.TabIndex = 3;
            this.NumericUpDownValueButton.Text = "Get value";
            this.NumericUpDownValueButton.UseVisualStyleBackColor = true;
            this.NumericUpDownValueButton.Click += new System.EventHandler(this.NumericUpDownValueButton_Click);
            // 
            // specialNumericUpDown1
            // 
            this.specialNumericUpDown1.DecimalPlaces = 2;
            this.specialNumericUpDown1.Location = new System.Drawing.Point(31, 38);
            this.specialNumericUpDown1.Name = "specialNumericUpDown1";
            this.specialNumericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.specialNumericUpDown1.TabIndex = 2;
            this.specialNumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 94);
            this.Controls.Add(this.NumericUpDownValueButton);
            this.Controls.Add(this.specialNumericUpDown1);
            this.Controls.Add(this.GetValueButton);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            ((System.ComponentModel.ISupportInitialize)(this.specialNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GetValueButton;
        private SpecialNumericUpDown specialNumericUpDown1;
        private System.Windows.Forms.Button NumericUpDownValueButton;
    }
}

