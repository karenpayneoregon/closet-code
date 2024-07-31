using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace DotNetRunTimeProcessStartApp
{
    internal partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            AnsiConsole.MarkupLine("");
            Console.Title = "PowerShell Code sample";
            WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
        }
        public static Table CreateTable()
        {
            var table = new Table()
                .RoundedBorder()
                .AddColumn("[white on blue]Product[/]")
                .AddColumn("[white on blue]Version[/]")
                .Alignment(Justify.Left)
                .BorderColor(Color.LightSlateGrey)
                .Title("[LightGreen]dotnet --list-runtimes[/]");
            return table;
        }
    }
}
