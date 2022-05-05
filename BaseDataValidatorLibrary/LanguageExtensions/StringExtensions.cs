using System.Text.RegularExpressions;

namespace BaseDataValidatorLibrary.LanguageExtensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Given a string with upper and lower cased letters separate them before each upper cased characters
        /// </summary>
        /// <param name="sender">String to work against</param>
        /// <returns>String with spaces between upper-case letters</returns>
        public static string SplitCamelCase(this string sender) 
            => Regex.Replace(Regex.Replace(sender, @"(\P{Ll})(\P{Ll}\p{Ll})", "$1 $2"), @"(\p{Ll})(\P{Ll})", "$1 $2");

        /// <summary>
        /// Determines if <see cref="character"/> is a through z and not empty
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        public static bool IsLetter(this char character) =>
            character is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') and not ' ';
    }
}
