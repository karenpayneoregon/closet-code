using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using MonthNamesDifferentLanguages.Classes;

namespace MonthNamesDifferentLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations.EnglishMonthList.ForEach(Console.WriteLine);
            Console.WriteLine();
            var culture = new CultureInfo("ru-RU");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            Operations.VietnameseMonthNames().ForEach(Console.WriteLine);
            Console.WriteLine();
            Operations.SpanishMonthNames().ForEach(Console.WriteLine);

            Console.ReadLine();
        }

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample - Months in different languages";
        }
    }
}
