using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomNumbersApp
{
    partial class Program
    {
        static void Main(string[] args)
        {

            var result = GetData();
            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key, -5}{kvp.Value}");
            }

            Console.ReadLine();
        }

        private static Dictionary<int, int> GetData()
        {
            Dictionary<int, int> dictionary = new();

            List<int> list = new() { 101, 221, 324, 471, 114, 233, 341, 443, 101, 324 };
            List<int> interested = new() { 324, 341, 471 };

            foreach (var dataItem in list.GroupBy(item => item).Select(group => new { Value = group.Key, Count = group.Count() }).OrderBy(x => x.Value))
            {

                if (interested.Contains(dataItem.Value))
                {
                    dictionary.Add(dataItem.Value, dataItem.Count);
                }

            }

            return dictionary;
        }
    }
}
