using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayNoDuplicates
{
    class Program
    {
        static readonly HashSet<int> _hashSet = new ();
        static void Main(string[] args)
        {
            int[] randomValues = { 1, 1, 2, 3, 4, 5, 6, 6 };

            foreach (var value in randomValues)
            {
                _hashSet.Add(value);
            }

            int[] values = _hashSet.ToArray();
            Console.WriteLine(string.Join(",", values));

            Console.ReadLine();
        }

    }
}
