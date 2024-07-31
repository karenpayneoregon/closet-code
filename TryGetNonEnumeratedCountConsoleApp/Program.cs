using System.Collections;
using System.Collections.Generic;
using TryGetNonEnumeratedCountConsoleApp.Data;
using TryGetNonEnumeratedCountConsoleApp.Models;

namespace TryGetNonEnumeratedCountConsoleApp
{
    internal partial class Program
    {
        static async Task Main(string[] args)
        {
            Example1();
            Console.WriteLine();
            await Example2();
            Console.ReadLine();
        }

        private static async Task Example2()
        {
            await using var context = new Context();
            IEnumerable<Contacts> contacts = context.Contacts.AsEnumerable();
            if (contacts.TryGetNonEnumeratedCount(out var count))
            {
                Console.WriteLine($"Yes {count}");
            }
            else
            {
                Console.WriteLine($"No {contacts.Count()}");
            }
        }


        private static void Example1()
        {
            IEnumerable<int> items = Enumerable.Range(0, 10);

            /*
             * to avoid this performance penalty, you can use TryGetNonEnumeratedCount
             * rather than count.
             *
             * It will first check if it is ‘safe’ to do a count in a fast way, if not it will return nothing.
             *
             * In short, no enumerating 
             */
            AnsiConsole.MarkupLine(items.TryGetNonEnumeratedCount(out var count)
                ? $"[white on blue]Number of elements =[/][yellow on blue] {count}[/]"
                : "[white on red]Nope[/]");
        }
    }

}