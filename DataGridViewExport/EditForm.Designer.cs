namespace DataGridViewExport;

partial class EditForm
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
        FirstNameTextBox = new TextBox();
        SaveButton = new Button();
        SuspendLayout();
        // 
        // FirstNameTextBox
        // 
        FirstNameTextBox.Location = new Point(12, 43);
        FirstNameTextBox.Name = "FirstNameTextBox";
        FirstNameTextBox.Size = new Size(283, 27);
        FirstNameTextBox.TabIndex = 0;
        // 
        // SaveButton
        // 
        SaveButton.Location = new Point(12, 76);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new Size(94, 29);
        SaveButton.TabIndex = 1;
        SaveButton.Text = "Save";
        SaveButton.TextAlign = ContentAlignment.TopCenter;
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += SaveButton_Click;
        // 
        // EditForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(338, 188);
        Controls.Add(SaveButton);
        Controls.Add(FirstNameTextBox);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "EditForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "EditForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox FirstNameTextBox;
    private Button SaveButton;
}