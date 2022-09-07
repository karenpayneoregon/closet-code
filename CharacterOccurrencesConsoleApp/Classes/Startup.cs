using System.Runtime.CompilerServices;
using D = ConsoleHelperLibrary.Classes.WindowUtility;
namespace CharacterOccurrencesConsoleApp.Classes;

internal class Startup
{
    [ModuleInitializer]
    public static void Init()
    {
        Console.Title = "Code sample";
        Console.SetWindowSize(40, 20);
        W.SetConsoleWindowPosition(W.AnchorWindow.Center);

        AnsiConsole.Write(
            new Panel(new Text("Character count simple").Centered())
                .Expand()
                .SquareBorder()
                .BorderStyle(new Style(Color.DarkViolet))
                .Header(ColorHelpers.Paint("About"))
                .HeaderAlignment(Justify.Center));
    }
}