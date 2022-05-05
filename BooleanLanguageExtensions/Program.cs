using System;
using System.Runtime.CompilerServices;
using BooleanLanguageExtensions.LanguageExtensions;
using BooleanLanguageExtensions.Models;

namespace BooleanLanguageExtensions
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (LanguageCode language in Enum.GetValues<LanguageCode>())
            {
                Console.WriteLine($"{language,-12}{true.ToYesNoStringIs(language),-12}{false.ToYesNoStringIs(language)}");
            }

            Console.ReadLine();
        }

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample - Bool extensions";
        }
    }
}
