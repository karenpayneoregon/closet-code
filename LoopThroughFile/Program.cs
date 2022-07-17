using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LoopThroughFileLibrary.Classes;


namespace LoopThroughFile
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var (total, badLines, exception) = Operations.GetTotals("example.txt");

            if (exception is null)
            {

                Console.WriteLine($"Total: {total:C2}");

                if (badLines.Any())
                {
                    Console.WriteLine($"Bad lines: {string.Join(",", badLines)}");
                }

            }
            else
            {
                Console.WriteLine(exception.Message);
            }

            Console.ReadLine();
        }
      
    }
}
