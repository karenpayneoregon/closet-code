using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsLibrary.LanguageExtensions
{
    public static class PictureBoxExtensions
    {
        /// <summary>
        /// Provides method to ensure if an image is in use we can still use it if needed delete it
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <param name="fileName">File name of image to load</param>
        /// <param name="remove">true to remove, false not to delete</param>
        public static void LoadClone(this PictureBox pictureBox, string fileName, bool remove = true)
        {
            var imageOriginal = Image.FromFile(fileName);
            var imageClone = new Bitmap(imageOriginal.Width, imageOriginal.Height);

            Graphics gr = Graphics.FromImage(imageClone);
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            gr.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            gr.DrawImage(imageOriginal, 0, 0, imageOriginal.Width, imageOriginal.Height);

            gr.Dispose();
            imageOriginal.Dispose();

            pictureBox.Image = imageClone; // assign the clone to picture box

            if (remove)
            {
                File.Delete(fileName); // remove original
            }

        }
    }
}