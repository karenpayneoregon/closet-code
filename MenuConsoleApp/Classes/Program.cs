using System;
using System.Runtime.CompilerServices;
using MenuConsoleApp.Classes;
using MenuConsoleApp.Models;
using Spectre.Console;

// ReSharper disable once CheckNamespace
namespace MenuConsoleApp
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample - Spectre.Console menu with EF Core";
        }
    }
}





