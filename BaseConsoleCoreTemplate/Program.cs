using System;
using static ConfigurationLibrary.Classes.ConfigurationHelper;

namespace BaseConsoleCoreTemplate
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Default connection string: {ConnectionString()}");
            Console.ReadLine();
        }
    }
}
