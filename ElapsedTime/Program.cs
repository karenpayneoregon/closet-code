using System;
using System.Runtime.CompilerServices;
using ElapsedTime.LanguageExtensions;

namespace ElapsedTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.Now.AddHours(-12).AddMinutes(1).AddSeconds(-20);
            var endDate = DateTime.Now;

            Console.WriteLine($"Result: {(endDate - startDate).FormatElapsed()}");

            Console.ReadLine();
        }

        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample - ElapsedTime";
        }
    }
}
