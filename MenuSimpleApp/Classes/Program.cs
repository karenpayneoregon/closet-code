﻿using System;
using System.Runtime.CompilerServices;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace MenuSimpleApp
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample - Spectre.Console menu basic";
            W.SetConsoleWindowPosition(W.AnchorWindow.Center);
        }
    }
}





