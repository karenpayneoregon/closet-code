using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;
using static ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace SequenceIssues
{
    partial class Program
    {
        private static void Render(Rule rule)
        {
            AnsiConsole.Write(rule);
            AnsiConsole.WriteLine();
        }
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample - Sequence missing?";
            SetConsoleWindowPosition(AnchorWindow.Center);
        }
    }
    
}
