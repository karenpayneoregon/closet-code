using System;
using System.Linq;
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
    }
}
