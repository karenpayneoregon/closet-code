using System;
using System.Linq;
using System.Threading.Tasks;
using NorthWind2020ConsoleApp.Classes;
using NorthWind2020ConsoleApp.Models;


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
