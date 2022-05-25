using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using NorthWind2020ConsoleApp.Classes;


namespace NorthWind2020ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeOperations.EmployeeReportsTo();
            Console.ReadLine();

        }
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample - EF Core NorthWind 2020";
        }
    }
}
