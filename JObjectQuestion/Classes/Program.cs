using System;
using System.Runtime.CompilerServices;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace JObjectQuestion
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {

            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
            Console.Title = "Code sample";
        }
    }
}





