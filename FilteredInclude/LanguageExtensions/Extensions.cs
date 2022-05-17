using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FilteredInclude.Models;

namespace FilteredInclude.LanguageExtensions
{
    public static class Extensions
    {

        public static IQueryable<Orders> WhereDatesBetween(this IQueryable<Orders> sender, DateTime startDate, DateTime endDate)
            => sender.Where(order => startDate <= order.OrderDate  && order.OrderDate <= endDate);

        public static string ToYesNo(this bool value)
            => value ? "Yes" : "No";

        /// <summary>
        /// Convert a json string to a list of T
        /// </summary>
        /// <typeparam name="T">Type to deserialize</typeparam>
        /// <param name="jsonString">Valid json</param>
        /// <returns>List&lt;T&gt;</returns>
        public static List<T> JSonToList<T>(this string jsonString)
            => JsonSerializer.Deserialize<List<T>>(jsonString, new JsonSerializerOptions());
    }
}
