using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.LanguageExtensions
{
    public static class Converters
    {
        /// <summary>
        /// Returns the reverse of the provided value.
        /// </summary>
        public static bool Not(this bool value) => !value;

        /// <summary>
        /// Determine if value can represent <see cref="T"/>
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="value">value to determine if <see cref="T"/></param>
        /// <returns>true if can represent <see cref="T"/> otherwise false</returns>
        public static bool Is<T>(this string value)
        {
            if (string.IsNullOrEmpty(value)) return false;

            var conv = TypeDescriptor.GetConverter(typeof(T));

            if (!conv.CanConvertFrom(typeof(string))) return false;

            try
            {
                conv.ConvertFrom(value);
                return true;
            }
            catch
            {
                // ignored
            }
            return false;
        }
    }
}
