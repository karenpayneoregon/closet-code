using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringLanguageExtensions.Containers;

namespace CharacterOccurrencesApp.LanguageExtensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Provides strong type return for use in a Lambda statement to split a string into chars along with their respected indices.
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>List&lt;CharIndexed&gt;</returns>
        public static List<CharIndexed> Indexed(this string sender)
            => sender.Select((@char, index) =>
                new CharIndexed { Char = @char, Index = index }).ToList();
    }
}
