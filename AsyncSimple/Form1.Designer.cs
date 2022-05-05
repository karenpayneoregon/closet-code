
namespace AsyncSimple
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
            this.StartButton = new System.Windows.Forms.Button();
            this.CancelItButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NoviceButton = new System.Windows.Forms.Button();
            this.FakeWorkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Image = global::AsyncSimple.Properties.Resources.ASX_Run_blue_16x;
            this.StartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartButton.Location = new System.Drawing.Point(29, 22);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // CancelItButton
            // 
            this.CancelItButton.Image = global::AsyncSimple.Properties.Resources.Cancel_7x_16x;
            this.CancelItButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelItButton.Location = new System.Drawing.Point(110, 22);
            this.CancelItButton.Name = "CancelItButton";
            this.CancelItButton.Size = new System.Drawing.Size(75, 23);
            this.CancelItButton.TabIndex = 1;
            this.CancelItButton.Text = "Cancel";
            this.CancelItButton.UseVisualStyleBackColor = true;
            this.CancelItButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(221, 26);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(38, 15);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StatusLabel);
            this.groupBox1.Controls.Add(this.CancelItButton);
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 101);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resonsive";
            // 
            // NoviceButton
            // 
            this.NoviceButton.Location = new System.Drawing.Point(36, 142);
            this.NoviceButton.Name = "NoviceButton";
            this.NoviceButton.Size = new System.Drawing.Size(89, 23);
            this.NoviceButton.TabIndex = 5;
            this.NoviceButton.Text = "Novice";
            this.NoviceButton.UseVisualStyleBackColor = true;
            this.NoviceButton.Click += new System.EventHandler(this.NoviceButton_Click);
            // 
            // FakeWorkButton
            // 
            this.FakeWorkButton.Location = new System.Drawing.Point(36, 171);
            this.FakeWorkButton.Name = "FakeWorkButton";
            this.FakeWorkButton.Size = new System.Drawing.Size(89, 23);
            this.FakeWorkButton.TabIndex = 6;
            this.FakeWorkButton.Text = "Do fake work";
            this.FakeWorkButton.UseVisualStyleBackColor = true;
            this.FakeWorkButton.Click += new System.EventHandler(this.FakeWorkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Good";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bad";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 257);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(454, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 279);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FakeWorkButton);
            this.Controls.Add(this.NoviceButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Responsive";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button CancelItButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NoviceButton;
        private System.Windows.Forms.Button FakeWorkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}

