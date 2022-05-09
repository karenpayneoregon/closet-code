﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HasQueryFilterApp.Classes
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

            const int shake_amplitude = 20;

            for (int index = 0; index < 15; index++)
            {
                
                sender.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), 
                    original.Y + rnd.Next(-shake_amplitude, shake_amplitude));

                System.Threading.Thread.Sleep(20);
            }

            sender.Location = original;

        }
    }
}
