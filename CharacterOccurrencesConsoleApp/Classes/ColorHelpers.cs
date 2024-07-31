using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterOccurrencesConsoleApp.Classes
{
    internal class ColorHelpers
    {
        /// <summary>
        /// Render string in White on DarkViolet
        /// </summary>
        /// <param name="text">text to display</param>
        public static string Paint(string text) => $"[white on DarkViolet]{text}[/]";
        /// <summary>
        /// Render char in White on DarkViolet
        /// </summary>
        /// <param name="text">text to display</param>
        public static string Paint(char text) => $"[white on DarkViolet]{text}[/]";
    }
}
