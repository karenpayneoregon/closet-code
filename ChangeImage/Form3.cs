using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChangeImage.Classes;
using ChangeImage.Extensions;

namespace ChangeImage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var allImages = ResourceImages.Instance.Images();
            AllImagesListBox.DataSource = allImages;
            
            ChangeFromAllImage();
            
            IconListBox.DataSource = allImages.Icons();
            
            BitmapListBox.DataSource = allImages.BitMaps();
        }

        private void SelectFromAllImagesButton_Click(object sender, EventArgs e)
        {
            ChangeFromAllImage();
        }

        private void ChangeFromAllImage()
        {
            if (AllImagesListBox.SelectedIndex <= -1) return;

            var item = (ResourceItem) AllImagesListBox.SelectedItem;
            pictureBox1.SizeMode = item.IsIcon ? PictureBoxSizeMode.Normal : PictureBoxSizeMode.Zoom;
            pictureBox1.Image = item.Image;
        }

        private void NamesInResourceButton_Click(object sender, EventArgs e)
        {
            var list = ImageHelper.ResourceImageNames();
            if (list.Contains("chat", StringComparer.OrdinalIgnoreCase))
            {
                
            }
            else
            {
                
            }
        }
    }
}
