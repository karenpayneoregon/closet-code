
namespace EventsGetInvocationListFormsApp
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
            this.SubscribeButton = new System.Windows.Forms.Button();
            this.UnsubscribeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EventCountButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SubscribeButton
            // 
            this.SubscribeButton.Location = new System.Drawing.Point(12, 12);
            this.SubscribeButton.Name = "SubscribeButton";
            this.SubscribeButton.Size = new System.Drawing.Size(75, 23);
            this.SubscribeButton.TabIndex = 0;
            this.SubscribeButton.Text = "Subscribe";
            this.SubscribeButton.UseVisualStyleBackColor = true;
            this.SubscribeButton.Click += new System.EventHandler(this.SubscribeButton_Click);
            // 
            // UnsubscribeButton
            // 
            this.UnsubscribeButton.Location = new System.Drawing.Point(12, 70);
            this.UnsubscribeButton.Name = "UnsubscribeButton";
            this.UnsubscribeButton.Size = new System.Drawing.Size(75, 23);
            this.UnsubscribeButton.TabIndex = 1;
            this.UnsubscribeButton.Text = "Unsubscribe";
            this.UnsubscribeButton.UseVisualStyleBackColor = true;
            this.UnsubscribeButton.Click += new System.EventHandler(this.UnsubscribeButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EventCountButton
            // 
            this.EventCountButton.Location = new System.Drawing.Point(12, 99);
            this.EventCountButton.Name = "EventCountButton";
            this.EventCountButton.Size = new System.Drawing.Size(75, 23);
            this.EventCountButton.TabIndex = 3;
            this.EventCountButton.Text = "Count";
            this.EventCountButton.UseVisualStyleBackColor = true;
            this.EventCountButton.Click += new System.EventHandler(this.EventCountButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(164, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(166, 134);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 230);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.EventCountButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UnsubscribeButton);
            this.Controls.Add(this.SubscribeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SubscribeButton;
        private System.Windows.Forms.Button UnsubscribeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EventCountButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}

