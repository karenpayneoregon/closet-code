
namespace ChangeImage
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AllImagesListBox = new System.Windows.Forms.ListBox();
            this.SelectFromAllImagesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IconListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BitmapListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NamesInResourceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(226, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AllImagesListBox
            // 
            this.AllImagesListBox.FormattingEnabled = true;
            this.AllImagesListBox.ItemHeight = 15;
            this.AllImagesListBox.Location = new System.Drawing.Point(12, 38);
            this.AllImagesListBox.Name = "AllImagesListBox";
            this.AllImagesListBox.Size = new System.Drawing.Size(185, 154);
            this.AllImagesListBox.TabIndex = 2;
            // 
            // SelectFromAllImagesButton
            // 
            this.SelectFromAllImagesButton.Location = new System.Drawing.Point(122, 12);
            this.SelectFromAllImagesButton.Name = "SelectFromAllImagesButton";
            this.SelectFromAllImagesButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFromAllImagesButton.TabIndex = 3;
            this.SelectFromAllImagesButton.Text = "Select";
            this.SelectFromAllImagesButton.UseVisualStyleBackColor = true;
            this.SelectFromAllImagesButton.Click += new System.EventHandler(this.SelectFromAllImagesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Icons and Bitmaps";
            // 
            // IconListBox
            // 
            this.IconListBox.FormattingEnabled = true;
            this.IconListBox.ItemHeight = 15;
            this.IconListBox.Location = new System.Drawing.Point(12, 219);
            this.IconListBox.Name = "IconListBox";
            this.IconListBox.Size = new System.Drawing.Size(185, 79);
            this.IconListBox.Sorted = true;
            this.IconListBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Icons only";
            // 
            // BitmapListBox
            // 
            this.BitmapListBox.FormattingEnabled = true;
            this.BitmapListBox.ItemHeight = 15;
            this.BitmapListBox.Location = new System.Drawing.Point(13, 326);
            this.BitmapListBox.Name = "BitmapListBox";
            this.BitmapListBox.Size = new System.Drawing.Size(185, 79);
            this.BitmapListBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bitmaps only";
            // 
            // NamesInResourceButton
            // 
            this.NamesInResourceButton.Location = new System.Drawing.Point(422, 405);
            this.NamesInResourceButton.Name = "NamesInResourceButton";
            this.NamesInResourceButton.Size = new System.Drawing.Size(75, 23);
            this.NamesInResourceButton.TabIndex = 10;
            this.NamesInResourceButton.Text = "button1";
            this.NamesInResourceButton.UseVisualStyleBackColor = true;
            this.NamesInResourceButton.Click += new System.EventHandler(this.NamesInResourceButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.NamesInResourceButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BitmapListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IconListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectFromAllImagesButton);
            this.Controls.Add(this.AllImagesListBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox AllImagesListBox;
        private System.Windows.Forms.Button SelectFromAllImagesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox IconListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox BitmapListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NamesInResourceButton;
    }
}