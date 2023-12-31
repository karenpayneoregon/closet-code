namespace WinFormsApp2;

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
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        BooksListBox1 = new ListBox();
        button5 = new Button();
        BooksListBox2 = new ListBox();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(23, 45);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 0;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new Point(23, 94);
        button2.Name = "button2";
        button2.Size = new Size(94, 29);
        button2.TabIndex = 1;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new Point(23, 147);
        button3.Name = "button3";
        button3.Size = new Size(94, 29);
        button3.TabIndex = 2;
        button3.Text = "button3";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Location = new Point(23, 193);
        button4.Name = "button4";
        button4.Size = new Size(94, 29);
        button4.TabIndex = 3;
        button4.Text = "button4";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // BooksListBox1
        // 
        BooksListBox1.FormattingEnabled = true;
        BooksListBox1.Location = new Point(265, 45);
        BooksListBox1.Name = "BooksListBox1";
        BooksListBox1.Size = new Size(325, 184);
        BooksListBox1.TabIndex = 4;
        // 
        // button5
        // 
        button5.Location = new Point(616, 45);
        button5.Name = "button5";
        button5.Size = new Size(94, 29);
        button5.TabIndex = 5;
        button5.Text = "button5";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // BooksListBox2
        // 
        BooksListBox2.FormattingEnabled = true;
        BooksListBox2.Location = new Point(265, 235);
        BooksListBox2.Name = "BooksListBox2";
        BooksListBox2.Size = new Size(325, 184);
        BooksListBox2.TabIndex = 6;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(BooksListBox2);
        Controls.Add(button5);
        Controls.Add(BooksListBox1);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private ListBox BooksListBox1;
    private Button button5;
    private ListBox BooksListBox2;
}
