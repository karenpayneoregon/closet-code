namespace CharacterOccurrencesConsoleApp;

using System.Runtime.CompilerServices;

internal class Program
{
    static void Main(string[] args)
    {
        IEnumerable<Container> containers = "AaB22bX1zZA1uUU1"
            .GroupBy(c => c)
            .Select(c => new Container(c.Key, c.Count()));

        var table = TableHelper.CreateViewTable();

        foreach (var container in containers)
        {

            
            table.AddRow(
                container.IsDigit
                    ? ColorHelpers.Paint(container.Char)
                    : container.Char.ToString(), container.Count.ToString());

            
        }

        AnsiConsole.Write(table);

        Console.ReadLine();
    }


}
