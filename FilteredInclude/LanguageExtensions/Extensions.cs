using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilteredInclude.Models;

namespace FilteredInclude.LanguageExtensions
{
    /// <summary>
    /// Common string extensions 
    /// </summary>
    public static class Extensions
    {

        public static IQueryable<Orders> WhereDatesBetween(this IQueryable<Orders> sender, DateTime startDate, DateTime endDate)
            => sender.Where(order => startDate <= order.OrderDate  && order.OrderDate <= endDate);

        public static string ToYesNo(this bool value)
            => value ? "Yes" : "No";
        /// <summary>
        /// Determine if string is empty
        /// </summary>
        /// <param name="sender">String to test if null or whitespace</param>
        /// <returns>true if empty or false if not empty</returns>
        [DebuggerStepThrough]
        public static bool IsNullOrWhiteSpace(this string sender) => string.IsNullOrWhiteSpace(sender);
        /// <summary>
        /// Determine if a string can be represented as a numeric.
        /// </summary>
        /// <param name="text">value to determine if can be converted to a string</param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public static bool IsNumeric(this string text) => double.TryParse(text, out _);
    }
}
