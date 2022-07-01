using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace BindingListAddRangeApp
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = @"Code sample - BindList AddRange extension";
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
        }
        public static Table GenericTable(string title) =>
            new Table()
                .RoundedBorder()
                .AddColumn("[black on white]Name[/]")
                .AddColumn("[black on white]Street[/]")
                .AddColumn("[black on white]Postal[/]")
                .Alignment(Justify.Center)
                .BorderColor(Color.LightSlateGrey)
                .Title($"[yellow]{title}[/]");
    }
}
