﻿using System;
using System.Runtime.CompilerServices;


// ReSharper disable once CheckNamespace
namespace CreateLocalDb
{
    partial class Program
    {
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = "Code sample";
        }
    }
}





