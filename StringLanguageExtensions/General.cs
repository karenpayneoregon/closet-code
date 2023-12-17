using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using StringLanguageExtensions.Containers;

namespace StringLanguageExtensions
{
    public static class General
    {
        public static int SecondIndexOf(this string sender) 
            => sender.IndexOf('.', sender.IndexOf('.') + 1);

        /// <summary>
        /// Get numbers from string
        /// </summary>
        /// <param name="text"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool AlphaToInteger(this string text, ref int result)
        {
            var value = Regex.Replace(text, "[^0-9]", "");
            return int.TryParse(value, out result);
        }

        /// <summary>
        /// Determine if one or more string values exists in a string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="tokens"></param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// if (fileContents.ContainsAny("error", "failed"))
        /// </code>
        /// </example>
        public static bool ContainsAny(this string sender, params string[] tokens)
        {
            foreach (string token in tokens)
            {
                if (sender.Contains(token, StringComparison.CurrentCultureIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether two specified String objects have the same value, case insensitive.
        /// </summary>
        /// <param name="first">The first string to compare, or null.</param>
        /// <param name="second">The second string to compare, or null.</param>
        /// <returns>
        /// true if the value of first is the same as the value of second; otherwise,
        /// false. If both first and second are null, the method returns true.
        /// </returns>
        public static bool EqualsIgnoreCase(this string first, string second)
            => string.Equals(first, second, StringComparison.OrdinalIgnoreCase);

        /// <summary>
        /// Determine if a string has duplicate values case sensitive
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>true if has duplicates otherwise false</returns>
        public static bool HasDuplications(this List<string> sender) =>
            sender.GroupBy(value => value).Any(@group => @group.Count() > 1);

        /// <summary>
        /// Provides strong type return for use in a Lambda statement to split a string into chars along with their respected indices.
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>List&lt;CharIndexed&gt;</returns>
        public static List<CharIndexed> Indexed(this string sender)
            => sender.Select((@char, index) =>
                new CharIndexed { Char = @char, Index = index }).ToList();

        /// <summary>
        /// Determine if a string can be represented as a numeric.
        /// </summary>
        /// <param name="sender">value to determine if can be converted to a string</param>
        /// <returns>true if sender can represent a number</returns>
        public static bool IsNumeric(this string sender)
            => double.TryParse(sender, out _);

        /// <summary>
        /// Determine if string is empty
        /// </summary>
        /// <param name="sender">String to test if null or whitespace</param>
        /// <returns>true if empty or false if not empty</returns>
        [DebuggerStepThrough]
        public static bool IsNullOrWhiteSpace(this string sender)
            => string.IsNullOrWhiteSpace(sender);

        /// <summary>
        /// Indicates if a string can represent a TimeSpan
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static bool IsValidTimeFormat(this string sender)
            => TimeSpan.TryParse(sender, out _);

        /// <summary>
        /// Convert a json string to a list of T
        /// </summary>
        /// <typeparam name="T">Type to deserialize</typeparam>
        /// <param name="jsonString">Valid json</param>
        /// <returns>List&lt;T&gt;</returns>
        public static List<T> JSonToList<T>(this string jsonString) 
            => JsonSerializer.Deserialize<List<T>>(jsonString);

        /// <summary>
        /// Join string array with " and " as the last delimiter.
        /// </summary>
        /// <param name="sender">String array to convert to delimited string</param>
        /// <returns>Delimited string</returns>
        public static string JoinWithLastSeparator(this string[] sender)
            => string.Join(", ", sender.Take(sender.Length - 1)) + (((sender.Length <= 1) ? "" : " and ") +
                                                                    sender.LastOrDefault());

        public static string JoinWithLastSeparator(this List<string> sender)
            => sender.ToArray().JoinWithLastSeparator();

        /// <summary>
        /// Wraps string.Join for a list.
        /// We could name it Join but that would override <see cref="Enumerable.Join"/>
        /// </summary>
        /// <param name="sender">list of string to join</param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static string JoinWith(this List<string> sender, string separator = ",")
            => string.Join(separator, sender.ToArray());

        /// <summary>
        /// Remove all white space in a string, at start, end and in-between
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static string RemoveAllWhiteSpace(this string sender)
            => sender
                .ToCharArray().Where(character => !char.IsWhiteSpace(character))
                .Select(character => character.ToString())
                .Aggregate((value1, value2) => value1 + value2);

        /// <summary>
        /// Replace string case-insensitive
        /// </summary>
        /// <param name="sender">String to work on</param>
        /// <param name="from">Find string</param>
        /// <param name="to">Replace string</param>
        /// <returns>original string with replacement or if none original string</returns>
        public static string ReplaceInsensitive(this string sender, string from, string to)
            => Regex.Replace(sender, @from, to, RegexOptions.IgnoreCase);

        /// <summary>
        /// Reverse a string
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>string reversed</returns>
        public static string ReverseEx(this string sender)
        {
            char[] charArray = sender.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        /// <summary>
        /// Get nullable <see cref="DateTime"/> as null or as a Date
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static DateTime? SafeDateTime(this string sender)
            => string.IsNullOrWhiteSpace(sender) ? null : Convert.ToDateTime(sender);

        /// <summary>
        /// Extract text between single quotes
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static string StringBetweenQuotes(this string sender)
        {
            var match = Regex.Match(sender, "'([^']*)");

            return match.Success ? match.Groups[1].Value : sender;

        }

        /// <summary>
        /// Use to split on upper-cased characters and separate with a single space.
        /// </summary>
        public static string SplitCamelCase(this string sender) =>
            string.Join(" ", Regex.Matches(sender, @"([A-Z][a-z]+)")
                .Select(m => m.Value));

        /// <summary>
        /// Get file name only, avoid multiple file extensions e.g. DirectoryGetFilesMultipleFilters.deps.json
        /// </summary>
        /// <param name="sender">Valid path and file name</param>
        /// <param name="stopper">Character to end at</param>
        /// <returns>File name without any extensions</returns>
        /// <remarks>
        /// No exception handling.
        /// </remarks>
        public static string UpTo(this string sender, string stopper = ".")
            => sender.Substring(0, Math.Max(0, sender.IndexOf(stopper, StringComparison.Ordinal)));

        /// <summary>
        /// Trim last character from a string while the stock <see cref="string.TrimEnd()"/> will trim multiples e.g. given Hello!!
        /// will return Hello while this extension given Hello!! will return Hello!
        /// </summary>
        /// <param name="sender">string to work on</param>
        /// <returns>Original string if null otherwise original string minus the last character</returns>
        public static string TrimLastCharacter(this string sender) =>
            string.IsNullOrWhiteSpace(sender) ?
                sender :
                sender[..^1];

        public static int SqueezeInt(this string sender)
        {
            return int.Parse(Regex.Match(sender, @"\d+").Value);
        }
    }
}
