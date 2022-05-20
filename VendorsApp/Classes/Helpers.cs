using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorsApp.Classes
{
    public class Helpers
    {
        /// <summary>
        /// Convert byte array to Icon
        /// </summary>
        /// <param name="bytes">Bytes to form a Icon</param>
        /// <returns>Icon</returns>
        public static Icon BytesToIcon(byte[] bytes)
        {
            using var ms = new MemoryStream(bytes);
            return new Icon(ms);

        }

    }
}
