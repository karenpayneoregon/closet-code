using System;
using System.Linq;
using NorthWind2020ConsoleApp.Data;

namespace NorthWind2020ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                var all = context.Employees.ToList();

                var managers = all.Where(x => !x.ReportsTo.HasValue).ToList();
                foreach (var manager in managers)
                {
                    Console.WriteLine($"{manager.FullName} - {manager.WorkersNavigation.Count}");
                }
                var workers = all.Where(x => x.ReportsTo.HasValue).ToList();

            }

            Console.ReadLine();
        }

        private static void Example1()
        {
            using (var context = new Context())
            {
                var employees = context.Employees.ToList();

                foreach (var employee in employees)
                {
                    if (!employee.ReportsTo.HasValue)
                    {
                        Console.WriteLine($"{employee.FullName}");
                        foreach (var worker in employee.WorkersNavigation)
                        {
                            Console.WriteLine($"\t{worker.FullName}");
                        }
                    }
                }
            }
        }
    }
}
