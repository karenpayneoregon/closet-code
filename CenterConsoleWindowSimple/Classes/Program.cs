using System;
using System.Runtime.CompilerServices;


// ReSharper disable once CheckNamespace
namespace CenterConsoleWindowSimple
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





