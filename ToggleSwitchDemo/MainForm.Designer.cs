
namespace ToggleSwitchDemo
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
            this.button1 = new System.Windows.Forms.Button();
            this.PlusRelayCheckBox = new System.Windows.Forms.CheckBox();
            this.MinusRelayCheckBox = new System.Windows.Forms.CheckBox();
            this.PreRelayCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowChildFormButton_Click);
            // 
            // PlusRelayCheckBox
            // 
            this.PlusRelayCheckBox.AutoSize = true;
            this.PlusRelayCheckBox.Location = new System.Drawing.Point(131, 16);
            this.PlusRelayCheckBox.Name = "PlusRelayCheckBox";
            this.PlusRelayCheckBox.Size = new System.Drawing.Size(71, 17);
            this.PlusRelayCheckBox.TabIndex = 1;
            this.PlusRelayCheckBox.Text = "Plus relay";
            this.PlusRelayCheckBox.UseVisualStyleBackColor = true;
            // 
            // MinusRelayCheckBox
            // 
            this.MinusRelayCheckBox.AutoSize = true;
            this.MinusRelayCheckBox.Location = new System.Drawing.Point(131, 39);
            this.MinusRelayCheckBox.Name = "MinusRelayCheckBox";
            this.MinusRelayCheckBox.Size = new System.Drawing.Size(79, 17);
            this.MinusRelayCheckBox.TabIndex = 2;
            this.MinusRelayCheckBox.Text = "Minus relay";
            this.MinusRelayCheckBox.UseVisualStyleBackColor = true;
            // 
            // PreRelayCheckBox
            // 
            this.PreRelayCheckBox.AutoSize = true;
            this.PreRelayCheckBox.Location = new System.Drawing.Point(131, 62);
            this.PreRelayCheckBox.Name = "PreRelayCheckBox";
            this.PreRelayCheckBox.Size = new System.Drawing.Size(73, 17);
            this.PreRelayCheckBox.TabIndex = 3;
            this.PreRelayCheckBox.Text = "Pre replay";
            this.PreRelayCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 149);
            this.Controls.Add(this.PreRelayCheckBox);
            this.Controls.Add(this.MinusRelayCheckBox);
            this.Controls.Add(this.PlusRelayCheckBox);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox PlusRelayCheckBox;
        private System.Windows.Forms.CheckBox MinusRelayCheckBox;
        private System.Windows.Forms.CheckBox PreRelayCheckBox;
    }
}