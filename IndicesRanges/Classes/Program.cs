﻿using System;
using System.Runtime.CompilerServices;
using IndicesRanges.Classes;


// ReSharper disable once CheckNamespace
namespace IndicesRanges
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample";
            WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
        }
    }
}





