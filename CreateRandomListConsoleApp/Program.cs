using System;
using System.Linq;
using CommonLibrary.Classes;
using CreateRandomListConsoleApp.Classes;
using Spectre.Console;

namespace CreateRandomListConsoleApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            RandomDates();
            Console.WriteLine();
            RandomIntegers();

            Console.ReadLine();
        }


    }
}
