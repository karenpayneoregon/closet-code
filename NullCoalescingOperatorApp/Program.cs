using System;
using NullCoalescingOperatorApp.Classes;

namespace NullCoalescingOperatorApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            AccountOperations.Show();
            ContactOperations.Show();
            Console.ReadLine();
        }
    }
}
