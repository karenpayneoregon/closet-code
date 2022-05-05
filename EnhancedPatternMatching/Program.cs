using System;
using System.Runtime.CompilerServices;
using EnhancedPatternMatching.LanguageExtensions;

namespace EnhancedPatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = "Karen Payne is At the zoo";

            foreach (var character in value)
            {
                Console.WriteLine($"{character} is a character: {character.IsLetterOrSeparator()}");
            }




            Console.ReadLine();
        }

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample";
        }

    }
}
