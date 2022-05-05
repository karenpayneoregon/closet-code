using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using SequenceIssues.LanguageExtensions;

namespace SequenceIssues
{
    class Program
    {
        static void Main(string[] args)
        {
            IsBroken();
            FindMissing();
            Console.ReadLine();
        }

        private static void IsBroken()
        {
            Console.WriteLine(nameof(IsBroken));
            int[] array = { 1, 2, 3, 5, 6, 8, 9, 10 };
            Console.WriteLine(array.IsSequenceBroken());
        }

        private static void FindMissing()
        {
            Console.WriteLine(nameof(FindMissing));
            int[] array = { 1, 2, 3, 5, 6, 8, 9, 10 };
            List<int> expected = new() { 4, 7 };

            Console.WriteLine(expected.SequenceEqual(array.SequenceFindMissing().Cast<int>().ToList()));
        }

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample - Sequence missing?";
        }
    }
}
