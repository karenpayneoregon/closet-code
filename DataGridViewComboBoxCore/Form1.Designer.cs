using DataGridViewComboBoxCore.Controls;

namespace DataGridViewComboBoxCore;

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
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CurrentButton = new System.Windows.Forms.Button();
            this.SetCurrentColorButton = new System.Windows.Forms.Button();
            this.IterateRowsButton = new System.Windows.Forms.Button();
            this.coreBindingNavigator1 = new DataGridViewComboBoxCore.Controls.CoreBindingNavigator();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.SetCurrentColorToSelectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coreBindingNavigator1)).BeginInit();
            this.coreBindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemTextBoxColumn,
            this.ColorComboBoxColumn});
            this.ProductsDataGridView.Location = new System.Drawing.Point(4, 58);
            this.ProductsDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.RowHeadersWidth = 51;
            this.ProductsDataGridView.Size = new System.Drawing.Size(437, 238);
            this.ProductsDataGridView.TabIndex = 4;
            // 
            // ItemTextBoxColumn
            // 
            this.ItemTextBoxColumn.HeaderText = "Item";
            this.ItemTextBoxColumn.MinimumWidth = 6;
            this.ItemTextBoxColumn.Name = "ItemTextBoxColumn";
            this.ItemTextBoxColumn.Width = 200;
            // 
            // ColorComboBoxColumn
            // 
            this.ColorComboBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColorComboBoxColumn.HeaderText = "Color";
            this.ColorComboBoxColumn.MinimumWidth = 6;
            this.ColorComboBoxColumn.Name = "ColorComboBoxColumn";
            this.ColorComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CurrentButton
            // 
            this.CurrentButton.Location = new System.Drawing.Point(16, 326);
            this.CurrentButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CurrentButton.Name = "CurrentButton";
            this.CurrentButton.Size = new System.Drawing.Size(100, 35);
            this.CurrentButton.TabIndex = 5;
            this.CurrentButton.Text = "Current";
            this.CurrentButton.UseVisualStyleBackColor = true;
            this.CurrentButton.Click += new System.EventHandler(this.CurrentButton_Click);
            // 
            // SetCurrentColorButton
            // 
            this.SetCurrentColorButton.Location = new System.Drawing.Point(340, 326);
            this.SetCurrentColorButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SetCurrentColorButton.Name = "SetCurrentColorButton";
            this.SetCurrentColorButton.Size = new System.Drawing.Size(100, 35);
            this.SetCurrentColorButton.TabIndex = 9;
            this.SetCurrentColorButton.Text = "Set color";
            this.SetCurrentColorButton.UseVisualStyleBackColor = true;
            this.SetCurrentColorButton.Click += new System.EventHandler(this.SetCurrentColorButton_Click);
            // 
            // IterateRowsButton
            // 
            this.IterateRowsButton.Location = new System.Drawing.Point(124, 326);
            this.IterateRowsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IterateRowsButton.Name = "IterateRowsButton";
            this.IterateRowsButton.Size = new System.Drawing.Size(100, 35);
            this.IterateRowsButton.TabIndex = 10;
            this.IterateRowsButton.Text = "Iterate rows";
            this.IterateRowsButton.UseVisualStyleBackColor = true;
            this.IterateRowsButton.Click += new System.EventHandler(this.IterateRowsButton_Click);
            // 
            // coreBindingNavigator1
            // 
            this.coreBindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.coreBindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAbout});
            this.coreBindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.coreBindingNavigator1.Name = "coreBindingNavigator1";
            this.coreBindingNavigator1.Size = new System.Drawing.Size(443, 27);
            this.coreBindingNavigator1.TabIndex = 11;
            this.coreBindingNavigator1.Text = "coreBindingNavigator1";
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonAbout.Text = "About";
            // 
            // SetCurrentColorToSelectButton
            // 
            this.SetCurrentColorToSelectButton.Location = new System.Drawing.Point(232, 326);
            this.SetCurrentColorToSelectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SetCurrentColorToSelectButton.Name = "SetCurrentColorToSelectButton";
            this.SetCurrentColorToSelectButton.Size = new System.Drawing.Size(100, 35);
            this.SetCurrentColorToSelectButton.TabIndex = 12;
            this.SetCurrentColorToSelectButton.Text = "Set none";
            this.SetCurrentColorToSelectButton.UseVisualStyleBackColor = true;
            this.SetCurrentColorToSelectButton.Click += new System.EventHandler(this.SetCurrentColorToSelectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 379);
            this.Controls.Add(this.SetCurrentColorToSelectButton);
            this.Controls.Add(this.coreBindingNavigator1);
            this.Controls.Add(this.IterateRowsButton);
            this.Controls.Add(this.SetCurrentColorButton);
            this.Controls.Add(this.CurrentButton);
            this.Controls.Add(this.ProductsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coreBindingNavigator1)).EndInit();
            this.coreBindingNavigator1.ResumeLayout(false);
            this.coreBindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    internal System.Windows.Forms.DataGridView ProductsDataGridView;
    private System.Windows.Forms.Button CurrentButton;
    private System.Windows.Forms.Button SetCurrentColorButton;
    private System.Windows.Forms.Button IterateRowsButton;

    #endregion

    private CoreBindingNavigator coreBindingNavigator1;
    private DataGridViewTextBoxColumn ItemTextBoxColumn;
    private DataGridViewComboBoxColumn ColorComboBoxColumn;
    private Button SetCurrentColorToSelectButton;
    private ToolStripButton toolStripButtonAbout;
}
