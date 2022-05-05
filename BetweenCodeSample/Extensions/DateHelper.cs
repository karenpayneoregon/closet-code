using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenCodeSample.Extensions
{
    public class DateHelper
    {
        /// <summary>
        /// Format date as days left
        /// </summary>
        /// <param name="expiryDate">Expiration date</param>
        /// <returns>days remaining</returns>
        public static string CalculateExpirationTime(DateTime expiryDate)
        {
            var currentDate = DateTime.Now;
            var dateDifference = (expiryDate - currentDate);
            return dateDifference.Days >= 1 ? $"{ dateDifference.Days } day(s)" : "Expired";
        }

        public static void ExpiredDemo()
        {
            DateTime expirationDate = new(2022, 1, 21);
            var expired = DateHelper.CalculateExpirationTime(expirationDate);
            var text = expired == "Expired" ? "License has expired" : $"License will expire on {expirationDate:MM/dd/yyyy} and only have {DateHelper.CalculateExpirationTime(expirationDate)} days left.";

            Console.WriteLine(text);

            expirationDate = new(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);
            expired = DateHelper.CalculateExpirationTime(expirationDate);
            text = expired == "Expired" ? "License has expired" : $"License will expire on {expirationDate:MM/dd/yyyy} and only have {DateHelper.CalculateExpirationTime(expirationDate)} days left.";

            Console.WriteLine(text);
        }
    }
}
