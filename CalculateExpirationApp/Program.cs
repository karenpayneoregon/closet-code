﻿using System;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateExpirationApp
{
    class Program
    {
        static async Task Main(string[] args)
        {

            //await ElapsedTime();
            ExpireCountDown();
            Console.ReadLine();
        }

        private static void ExpireCountDown()
        {
            var dates = Enumerable.Range(1, 11).Select(x => DateTime.Now.AddDays(x));
            DateTime expireDate = DateTime.Now.AddDays(12);
            foreach (var date in dates)
            {
                Console.WriteLine($"{date,-10:MM/dd}{expireDate.DaysToExpiration(date)}");
            }
        }

        private static async Task ElapsedTime()
        {
            var endDate = DateTime.Now;

            for (int index = 1; index < 5; index++)
            {
                var startDate = DateTime.Now.AddHours(-index).AddMinutes(1).AddSeconds(-index);
                Console.SetCursorPosition(0,0);
                Console.WriteLine($"{(endDate - startDate).FormatElapsed()}");
                await Task.Delay(1000);
            }
            
        }
    }
}

