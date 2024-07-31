namespace WinFormsApp1;

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
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CurrentSelectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(12, 27);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(255, 28);
            this.CategoryComboBox.TabIndex = 0;
            // 
            // CurrentSelectionButton
            // 
            this.CurrentSelectionButton.Location = new System.Drawing.Point(282, 26);
            this.CurrentSelectionButton.Name = "CurrentSelectionButton";
            this.CurrentSelectionButton.Size = new System.Drawing.Size(139, 29);
            this.CurrentSelectionButton.TabIndex = 1;
            this.CurrentSelectionButton.Text = "Get current";
            this.CurrentSelectionButton.UseVisualStyleBackColor = true;
            this.CurrentSelectionButton.Click += new System.EventHandler(this.CurrentSelectionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 76);
            this.Controls.Add(this.CurrentSelectionButton);
            this.Controls.Add(this.CategoryComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.ResumeLayout(false);

    }

    #endregion

    private ComboBox CategoryComboBox;
    private Button CurrentSelectionButton;
}
