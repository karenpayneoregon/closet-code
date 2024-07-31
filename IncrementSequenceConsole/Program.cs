using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
/*
 * Aliasing a class is a better idea than a static using statement.
 * In this case neither aliasing for static using statement helps,
 * it's here so those who stumble on this code can learn about it.
 */
using H = IncrementSequenceConsole.Classes.Helpers;

namespace IncrementSequenceConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            BasicExample();
            Console.ReadLine();
        }

        private static void BasicExample()
        {
            Console.WriteLine($"          F1124   {H.NextValue("F1124")}");
            Console.WriteLine($"       1278-120   {H.NextValue("1278-120")}");
            Console.WriteLine($"           F102   {H.NextValue("F102")}");
            Console.WriteLine($"3999/IKL/VII/21   {H.NextValue("3999/IKL/VII/21")}");

            int someValue = 0;
            int maxValue = 110;

            while (someValue < maxValue)
            {
                Console.WriteLine($"{someValue,-18}{H.NextValue($"{someValue:D3}")}/{maxValue}");
                someValue++;
            }

        }

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code NextValue sample";
        }
    }
}
