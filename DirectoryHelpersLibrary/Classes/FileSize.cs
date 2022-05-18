using System;

namespace DirectoryHelpersLibrary.Classes
{
    public static class FileSize
    {
        private static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        /// <summary>
        /// Format int as readable file size
        /// </summary>
        /// <param name="value">value to format</param>
        /// <param name="decimalPlaces">decimal places, default is 1</param>
        /// <returns></returns>
        public static string SizeSuffix(this long value, int decimalPlaces = 1)
        {

            if (value < 0)
            {
                return "-" + SizeSuffix(-value);
            }

            int size = 0;
            var decimalValue = (decimal)value;

            while (Math.Round(decimalValue, decimalPlaces) >= 1000)
            {
                decimalValue /= 1024M;
                size += 1;
            }

            return string.Format("{0:n" + decimalPlaces + "} {1}", decimalValue, SizeSuffixes[size]);

        }
    }
}