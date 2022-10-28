using DotNetRunTimeProcessStartApp.Classes;

namespace DotNetRunTimeProcessStartApp;

internal partial class Program
{
    static async Task Main(string[] args)
    {
        AnsiConsole.MarkupLine("[yellow]dotnet --list-runtimes[/]");
        var (success, details, localException) = await Operations.Execute();
        if (success)
        {
            Console.WriteLine(details);
        }
        else if (localException is not null)
        {
            Console.WriteLine(localException.Message);
        }
        Console.ReadLine();
    }
}