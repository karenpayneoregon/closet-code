using System;
using System.IO;

namespace MsBuildMakeDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs")));
            Console.ReadLine();
        }
    }
}
