using System.Text.RegularExpressions;

namespace QueryFormatUtility.Extensions
{
    /// <summary>
    /// https://khalidabuhakmeh.com/flatten-strings-with-regex-replace
    /// </summary>
    public static class StringExtensions
    {
        private static readonly Regex Whitespace = new(@"\s+");

        public static string Flatten(this string value)
            => value is null or "" ? 
                value : 
                Whitespace.Replace(value.Trim(), " ");

        public static string Sql(string value) 
            => Flatten(value);
    }
}
