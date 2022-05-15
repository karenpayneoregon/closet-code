
namespace TimeComboboxApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TimeComboBox1 = new WindowsControlLibrary.Classes.TimeComboBox();
            this.GetTimeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IncrementsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TimeComboBox1
            // 
            this.TimeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeComboBox1.FormatString = "03:30 AM";
            this.TimeComboBox1.FormattingEnabled = true;
            this.TimeComboBox1.Increment = CommonLibrary.Classes.TimeIncrement.HalfHour;
            this.TimeComboBox1.IntegralHeight = false;
            this.TimeComboBox1.Items.AddRange(new object[] {
            "12:00 AM",
            "12:30 AM",
            "01:00 AM",
            "01:30 AM",
            "02:00 AM",
            "02:30 AM",
            "03:00 AM",
            "03:30 AM",
            "04:00 AM",
            "04:30 AM",
            "05:00 AM",
            "05:30 AM",
            "06:00 AM",
            "06:30 AM",
            "07:00 AM",
            "07:30 AM",
            "08:00 AM",
            "08:30 AM",
            "09:00 AM",
            "09:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "01:00 PM",
            "01:30 PM",
            "02:00 PM",
            "02:30 PM",
            "03:00 PM",
            "03:30 PM",
            "04:00 PM",
            "04:30 PM",
            "05:00 PM",
            "05:30 PM",
            "06:00 PM",
            "06:30 PM",
            "07:00 PM",
            "07:30 PM",
            "08:00 PM",
            "08:30 PM",
            "09:00 PM",
            "09:30 PM",
            "10:00 PM",
            "10:30 PM",
            "11:00 PM",
            "11:30 PM",
            "12:00 AM",
            "12:30 AM",
            "01:00 AM",
            "01:30 AM",
            "02:00 AM",
            "02:30 AM",
            "03:00 AM",
            "03:30 AM",
            "04:00 AM",
            "04:30 AM",
            "05:00 AM",
            "05:30 AM",
            "06:00 AM",
            "06:30 AM",
            "07:00 AM",
            "07:30 AM",
            "08:00 AM",
            "08:30 AM",
            "09:00 AM",
            "09:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "01:00 PM",
            "01:30 PM",
            "02:00 PM",
            "02:30 PM",
            "03:00 PM",
            "03:30 PM",
            "04:00 PM",
            "04:30 PM",
            "05:00 PM",
            "05:30 PM",
            "06:00 PM",
            "06:30 PM",
            "07:00 PM",
            "07:30 PM",
            "08:00 PM",
            "08:30 PM",
            "09:00 PM",
            "09:30 PM",
            "10:00 PM",
            "10:30 PM",
            "11:00 PM",
            "11:30 PM",
            "12:00 AM",
            "12:30 AM",
            "01:00 AM",
            "01:30 AM",
            "02:00 AM",
            "02:30 AM",
            "03:00 AM",
            "03:30 AM",
            "04:00 AM",
            "04:30 AM",
            "05:00 AM",
            "05:30 AM",
            "06:00 AM",
            "06:30 AM",
            "07:00 AM",
            "07:30 AM",
            "08:00 AM",
            "08:30 AM",
            "09:00 AM",
            "09:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "01:00 PM",
            "01:30 PM",
            "02:00 PM",
            "02:30 PM",
            "03:00 PM",
            "03:30 PM",
            "04:00 PM",
            "04:30 PM",
            "05:00 PM",
            "05:30 PM",
            "06:00 PM",
            "06:30 PM",
            "07:00 PM",
            "07:30 PM",
            "08:00 PM",
            "08:30 PM",
            "09:00 PM",
            "09:30 PM",
            "10:00 PM",
            "10:30 PM",
            "11:00 PM",
            "11:30 PM",
            "12:00 AM",
            "12:30 AM",
            "01:00 AM",
            "01:30 AM",
            "02:00 AM",
            "02:30 AM",
            "03:00 AM",
            "03:30 AM",
            "04:00 AM",
            "04:30 AM",
            "05:00 AM",
            "05:30 AM",
            "06:00 AM",
            "06:30 AM",
            "07:00 AM",
            "07:30 AM",
            "08:00 AM",
            "08:30 AM",
            "09:00 AM",
            "09:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "01:00 PM",
            "01:30 PM",
            "02:00 PM",
            "02:30 PM",
            "03:00 PM",
            "03:30 PM",
            "04:00 PM",
            "04:30 PM",
            "05:00 PM",
            "05:30 PM",
            "06:00 PM",
            "06:30 PM",
            "07:00 PM",
            "07:30 PM",
            "08:00 PM",
            "08:30 PM",
            "09:00 PM",
            "09:30 PM",
            "10:00 PM",
            "10:30 PM",
            "11:00 PM",
            "11:30 PM",
            "12:00 AM",
            "12:30 AM",
            "01:00 AM",
            "01:30 AM",
            "02:00 AM",
            "02:30 AM",
            "03:00 AM",
            "03:30 AM",
            "04:00 AM",
            "04:30 AM",
            "05:00 AM",
            "05:30 AM",
            "06:00 AM",
            "06:30 AM",
            "07:00 AM",
            "07:30 AM",
            "08:00 AM",
            "08:30 AM",
            "09:00 AM",
            "09:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "01:00 PM",
            "01:30 PM",
            "02:00 PM",
            "02:30 PM",
            "03:00 PM",
            "03:30 PM",
            "04:00 PM",
            "04:30 PM",
            "05:00 PM",
            "05:30 PM",
            "06:00 PM",
            "06:30 PM",
            "07:00 PM",
            "07:30 PM",
            "08:00 PM",
            "08:30 PM",
            "09:00 PM",
            "09:30 PM",
            "10:00 PM",
            "10:30 PM",
            "11:00 PM",
            "11:30 PM"});
            this.TimeComboBox1.Location = new System.Drawing.Point(12, 12);
            this.TimeComboBox1.MaxDropDownItems = 10;
            this.TimeComboBox1.Name = "TimeComboBox1";
            this.TimeComboBox1.Size = new System.Drawing.Size(80, 23);
            this.TimeComboBox1.TabIndex = 0;
            this.TimeComboBox1.Time = "03:30 AM";
            // 
            // GetTimeButton
            // 
            this.GetTimeButton.Location = new System.Drawing.Point(109, 12);
            this.GetTimeButton.Name = "GetTimeButton";
            this.GetTimeButton.Size = new System.Drawing.Size(75, 23);
            this.GetTimeButton.TabIndex = 1;
            this.GetTimeButton.Text = "Get";
            this.GetTimeButton.UseVisualStyleBackColor = true;
            this.GetTimeButton.Click += new System.EventHandler(this.GetTimeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // IncrementsComboBox
            // 
            this.IncrementsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IncrementsComboBox.FormattingEnabled = true;
            this.IncrementsComboBox.Location = new System.Drawing.Point(109, 42);
            this.IncrementsComboBox.Name = "IncrementsComboBox";
            this.IncrementsComboBox.Size = new System.Drawing.Size(121, 23);
            this.IncrementsComboBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 132);
            this.Controls.Add(this.IncrementsComboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GetTimeButton);
            this.Controls.Add(this.TimeComboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsControlLibrary.Classes.TimeComboBox TimeComboBox1;
        private System.Windows.Forms.Button GetTimeButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox IncrementsComboBox;
    }
}

