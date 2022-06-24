using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DiacriticsConsoleApp
{
    public class ConvertHelper
    {
        public static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (Rune rune in normalizedString.EnumerateRunes())
            {
                var unicodeCategory = Rune.GetUnicodeCategory(rune);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(rune);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
        public static Dictionary<char, string> Mapper => new()
        {
            { 'П', "P" },
            { 'е', "e" },
            { 'т', "t" },
            { 'р', "r" },
        };
    }

}
