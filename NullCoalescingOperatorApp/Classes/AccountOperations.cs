using System;
using System.Collections.Generic;
using NullCoalescingOperatorApp.Models;

namespace NullCoalescingOperatorApp.Classes
{
    public class AccountOperations
    {
        /// <summary>
        /// Combining null coalescing operator with a conditional
        /// </summary>
        public static void Show()
        {
            Account account = new ()
            {
                Settings = new List<Setting>() { new () { Key = "Balance" } }
            };

            var result1 = account.GetSetting("Balance");
            Console.WriteLine(result1.Key);
            var result2 = account.GetSetting("Summary");
            Console.WriteLine(result2.Key);
        }
    }
}