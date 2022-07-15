
namespace CloneImageForPictureBox
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
            this.pbImage1 = new System.Windows.Forms.PictureBox();
            this.pbImage2 = new System.Windows.Forms.PictureBox();
            this.DeleteCheckBox = new System.Windows.Forms.CheckBox();
            this.OopsCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage1
            // 
            this.pbImage1.Location = new System.Drawing.Point(23, 22);
            this.pbImage1.Name = "pbImage1";
            this.pbImage1.Size = new System.Drawing.Size(318, 214);
            this.pbImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage1.TabIndex = 0;
            this.pbImage1.TabStop = false;
            // 
            // pbImage2
            // 
            this.pbImage2.Location = new System.Drawing.Point(396, 22);
            this.pbImage2.Name = "pbImage2";
            this.pbImage2.Size = new System.Drawing.Size(318, 214);
            this.pbImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage2.TabIndex = 1;
            this.pbImage2.TabStop = false;
            // 
            // DeleteCheckBox
            // 
            this.DeleteCheckBox.AutoSize = true;
            this.DeleteCheckBox.Location = new System.Drawing.Point(23, 260);
            this.DeleteCheckBox.Name = "DeleteCheckBox";
            this.DeleteCheckBox.Size = new System.Drawing.Size(119, 19);
            this.DeleteCheckBox.TabIndex = 2;
            this.DeleteCheckBox.Text = "DeleteCode exists";
            this.DeleteCheckBox.UseVisualStyleBackColor = true;
            // 
            // OopsCheckBox
            // 
            this.OopsCheckBox.AutoSize = true;
            this.OopsCheckBox.Location = new System.Drawing.Point(396, 260);
            this.OopsCheckBox.Name = "OopsCheckBox";
            this.OopsCheckBox.Size = new System.Drawing.Size(93, 19);
            this.OopsCheckBox.TabIndex = 3;
            this.OopsCheckBox.Text = "Ooops exists";
            this.OopsCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 304);
            this.Controls.Add(this.OopsCheckBox);
            this.Controls.Add(this.DeleteCheckBox);
            this.Controls.Add(this.pbImage2);
            this.Controls.Add(this.pbImage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clone with option to delete";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage1;
        private System.Windows.Forms.PictureBox pbImage2;
        private System.Windows.Forms.CheckBox DeleteCheckBox;
        private System.Windows.Forms.CheckBox OopsCheckBox;
    }
}

