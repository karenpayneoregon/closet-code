using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Spectre.Console;
using SwitchExpressions.Classes;

namespace SwitchExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Examples.GuardedUnGuarded();
            //Console.WriteLine();
            //Examples.RecursivePatternMatching();

            LikesExample.Run();

            //Console.ReadLine();
        }

        
        [ModuleInitializer]
        public static void Init()
        {
            Console.Title = $"{Howdy.TimeOfDay()} Switch Expressions samples";
        }
    }


}
