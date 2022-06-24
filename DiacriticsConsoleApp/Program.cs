using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace DiacriticsConsoleApp
{
    /// <summary>
    /// </summary>
    /// <remarks>
    /// See also
    /// https://docs.microsoft.com/en-us/samples/dotnet/samples/cyrillic-transliteration-cs/
    /// https://github.com/dotnet/samples/tree/main/core/encoding/cyrillic-to-latin/cs
    /// </remarks>
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertHelper.RemoveDiacritics("bē gē"));
            Console.WriteLine(string.Concat("Пет".Select(c => ConvertHelper.Mapper[c])));
            Console.ReadLine();
        }
    }

}
