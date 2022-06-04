using System;
using System.Drawing;
using System.Windows.Forms;

namespace ValidatingFormProject.Classes
{
    public class FunStuff
    {
        /// <summary>
        /// Mildly shake a form
        /// </summary>
        /// <param name="sender">Form to shake</param>
        public static void Shake(Form sender)
        {
            var original = sender.Location;
            var rnd = new Random(1337);

            const int shake_amplitude = 3;

            for (int index = 0; index < 5; index++)
            {
                
                sender.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), 
                    original.Y + rnd.Next(-shake_amplitude, shake_amplitude));

                System.Threading.Thread.Sleep(20);
            }

            sender.Location = original;

        }
    }
}
