using EnhancedPatternMatching.Models;

namespace EnhancedPatternMatching.LanguageExtensions
{
    public static class Helpers
    {
        /// <summary>
        /// Pattern matching
        /// </summary>
        public static bool IsLetterOrSeparator(this char character) =>
            character is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z')
                or '.' or ',' and not ' ';

        /// <summary>
        /// Conventional
        /// </summary>
        public static bool IsLetterSeparator(this char character) => 
            char.IsLetter(character) || char.IsSeparator(character) && !char.IsWhiteSpace(character);

        public static string Greetings(this Visitor visitor) => visitor switch
        {
            { Country: "USA" } => "Hello",
            { Country: "Germany" } => "hallo",
            { Country: "Mexico" } => "Hola",
            _ => throw new ArgumentOutOfRangeException(nameof(visitor), visitor, null)
        };
    }
}