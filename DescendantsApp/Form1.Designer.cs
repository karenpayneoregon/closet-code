namespace DescendantsApp;

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
        panel1 = new Panel();
        button2 = new Button();
        button1 = new Button();
        button3 = new Button();
        button4 = new Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(button2);
        panel1.Location = new Point(146, 105);
        panel1.Name = "panel1";
        panel1.Size = new Size(250, 125);
        panel1.TabIndex = 0;
        // 
        // button2
        // 
        button2.Location = new Point(23, 14);
        button2.Name = "button2";
        button2.Size = new Size(94, 29);
        button2.TabIndex = 1;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button1
        // 
        button1.Location = new Point(39, 50);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 0;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button3
        // 
        button3.Location = new Point(159, 255);
        button3.Name = "button3";
        button3.Size = new Size(94, 29);
        button3.TabIndex = 1;
        button3.Text = "button3";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Location = new Point(167, 263);
        button4.Name = "button4";
        button4.Size = new Size(94, 29);
        button4.TabIndex = 2;
        button4.Text = "button4";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button1);
        Controls.Add(panel1);
        Name = "Form1";
        Text = "Form1";
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Button button2;
    private Button button1;
    private Button button3;
    private Button button4;
}
