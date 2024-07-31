using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using NorthWind2020ConsoleApp.Classes;
using NorthWind2020ConsoleApp.Models;
using Spectre.Console;


namespace NorthWind2020ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        List<Employees> managers = CoreOperations.GetManagers();
        AnsiConsole.MarkupLine("[cyan]Managers[/]");
        foreach (var manager in managers)
        {
            Console.WriteLine($"{manager.EmployeeId, -3}{manager.FirstName,-10}{manager.LastName}");
        }

        Console.WriteLine();

        CoreOperations.EmployeeReportsToManager();
        Console.ReadLine();
    }

    [ModuleInitializer]
    public static void Init()
    {
        Console.Title = "Code sample - EF Core NorthWind 2020";
    }
}