using System;
using System.Text.RegularExpressions;

namespace CreateDynamicControls.Classes.Extensions
{
    public static class StringExtensions
    {
        
        public static string SplitCamelCase(this string sender) 
            => Regex.Replace(Regex.Replace(
                sender, 
                "(\\P{Ll})(\\P{Ll}\\p{Ll})", "$1 $2"), 
                "(\\p{Ll})(\\P{Ll})", "$1 $2");

        public static string FirstPart(this string sender)
        {
            var parts = sender.SplitCamelCase().Split(' ');
            return parts.Length > -1 ? parts[0] : sender;
        }
    }
}
