using System.Runtime.CompilerServices;

namespace DecimalFun
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal value = 22_111.1111m;
            Console.WriteLine($"{value} has {value.CountDecimalPlaces()} places to the right");

            value = 111m;
            Console.WriteLine($"{value} has {value.CountDecimalPlaces()} places to the right");

            decimal fraction = 2.78m;
     
            Console.WriteLine($"{fraction.GetFraction()} from {fraction}");


            Console.ReadLine();
        }
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample - Fun with decimals";
        }
    }
}
