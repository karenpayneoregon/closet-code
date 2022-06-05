using System;
using System.Runtime.CompilerServices;
using W = ConsoleHelperLibrary.Classes.WindowUtility;
namespace CenterConsoleWindowSimple
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        [ModuleInitializer]
        public static void CenterWindow()
        {
            // center this window
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
        }
    }
}
