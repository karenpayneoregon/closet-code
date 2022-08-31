using IncrementSequenceDemos.Classes;
using IncrementSequenceDemos.Models;
using Spectre.Console;

namespace IncrementSequenceDemos
{
    partial  class Program
    {
        static void Main(string[] args)
        {
            
            var table = CreateViewTable();

            List<Invoice> list = Operations.DeserializeInvoices();

            foreach (var invoice in list)
            {
                table.AddRow(invoice.Id.ToString(), invoice.Number);
            }

            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine();
            }

            AnsiConsole.Write(table);

            Operations.Save(list);

            Console.ReadLine();
        }
    }
}