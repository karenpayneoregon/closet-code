using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QueryFormatUtility.Extensions
{
    public static class StringExtensions
    {
        private static readonly Regex Whitespace = new(@"\s+");

        public static string Flatten(this string value) 
            => value is null or "" ? value : Whitespace.Replace(value.Trim(), " ");

        public static string Sql(string value)
        {
            return Flatten(value);
        }
    }
}
