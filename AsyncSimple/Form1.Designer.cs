
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
            StartButton = new System.Windows.Forms.Button();
            CancelItButton = new System.Windows.Forms.Button();
            StatusLabel = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            NoviceButton = new System.Windows.Forms.Button();
            FakeWorkButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            button1 = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Image = Properties.Resources.ASX_Run_blue_16x;
            StartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            StartButton.Location = new System.Drawing.Point(33, 29);
            StartButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            StartButton.Name = "StartButton";
            StartButton.Size = new System.Drawing.Size(86, 31);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // CancelItButton
            // 
            CancelItButton.Image = Properties.Resources.Cancel_7x_16x;
            CancelItButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            CancelItButton.Location = new System.Drawing.Point(126, 29);
            CancelItButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            CancelItButton.Name = "CancelItButton";
            CancelItButton.Size = new System.Drawing.Size(86, 31);
            CancelItButton.TabIndex = 1;
            CancelItButton.Text = "Cancel";
            CancelItButton.UseVisualStyleBackColor = true;
            CancelItButton.Click += CancelButton_Click;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new System.Drawing.Point(253, 35);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new System.Drawing.Size(50, 20);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(StatusLabel);
            groupBox1.Controls.Add(CancelItButton);
            groupBox1.Controls.Add(StartButton);
            groupBox1.Location = new System.Drawing.Point(8, 3);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Size = new System.Drawing.Size(465, 135);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resonsive";
            // 
            // NoviceButton
            // 
            NoviceButton.Location = new System.Drawing.Point(41, 189);
            NoviceButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            NoviceButton.Name = "NoviceButton";
            NoviceButton.Size = new System.Drawing.Size(102, 31);
            NoviceButton.TabIndex = 5;
            NoviceButton.Text = "Novice";
            NoviceButton.UseVisualStyleBackColor = true;
            NoviceButton.Click += NoviceButton_Click;
            // 
            // FakeWorkButton
            // 
            FakeWorkButton.Location = new System.Drawing.Point(41, 228);
            FakeWorkButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            FakeWorkButton.Name = "FakeWorkButton";
            FakeWorkButton.Size = new System.Drawing.Size(102, 31);
            FakeWorkButton.TabIndex = 6;
            FakeWorkButton.Text = "Do fake work";
            FakeWorkButton.UseVisualStyleBackColor = true;
            FakeWorkButton.Click += FakeWorkButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(152, 235);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 20);
            label1.TabIndex = 7;
            label1.Text = "Good";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(152, 200);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(35, 20);
            label2.TabIndex = 8;
            label2.Text = "Bad";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripProgressBar1 });
            statusStrip1.Location = new System.Drawing.Point(0, 345);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip1.Size = new System.Drawing.Size(519, 27);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new System.Drawing.Size(114, 19);
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(379, 145);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += PerformWorkButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(519, 372);
            Controls.Add(button1);
            Controls.Add(statusStrip1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(FakeWorkButton);
            Controls.Add(NoviceButton);
            Controls.Add(groupBox1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Responsive";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Button button1;
    }
}

