using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using ChangeImage.Properties;

namespace ChangeImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void OpenFormButton_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            
            form2.OnChangeImage += Form2OnChangeImage;
            form2.OnChangeImageByName += Form2OnChangeImageByName;
            
            form2.Show();
        }

        private void Form2OnChangeImageByName(string name)
        {

            if (Resources.ResourceManager.GetObject(name) is Icon)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                pictureBox1.Image = ((Icon) Resources.ResourceManager.GetObject(name))?.ToBitmap();
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = (Bitmap)Resources.ResourceManager.GetObject(name);
            }
            
        }

        private void Form2OnChangeImage(Bitmap image)
        {
            pictureBox1.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
