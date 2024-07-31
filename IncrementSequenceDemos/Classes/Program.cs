using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using IncrementSequenceDemos.Classes;
using Spectre.Console;
using W = ConsoleHelperLibrary.Classes.WindowUtility;
// ReSharper disable once CheckNamespace
namespace IncrementSequenceDemos;

partial class Program
{

    [ModuleInitializer]
    public static void Init()
    {
        //Operations.Reset();
        Console.Title = "Code sample";

        W.SetConsoleWindowPosition(W.AnchorWindow.Center);
        if (!File.Exists(Operations.FileName))
        {
            Operations.CreateReadInvoice();
        }
    }

    private static Table CreateViewTable() =>
        new Table()
            .Border(TableBorder.Square)
            .BorderColor(Color.Grey100)
            .Centered()
            .Title("[yellow][B]Invoices[/][/]")
            .AddColumn(new TableColumn("[u]Id[/]"))
            .AddColumn(new TableColumn("[u]Number[/]"));
}