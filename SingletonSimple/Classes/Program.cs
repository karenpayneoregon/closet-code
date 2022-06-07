using System;
using System.Runtime.CompilerServices;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace SingletonSimple
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            // center this window
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
            Console.Title = "Code sample";
        }
    }
}





