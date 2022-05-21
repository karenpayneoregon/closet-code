using System;

namespace CalculateExpirationApp
{
    public static class DateHelper
    {
        public static int DaysToExpiration(this DateTime expiryDate, DateTime currentDate) 
            =>  (expiryDate - currentDate).Days;

        public static string CalculateExpirationTime(DateTime expiryDate)
        {

            var dateDifference = expiryDate - DateTime.Now;

            switch (dateDifference)
            {
                case { Days: >= 1 }:
                    return $"{ dateDifference.Days } day(s) remained";
                default:
                {
                    switch (dateDifference)
                    {
                        case { Hours: >= 1 }:
                            return $"{ dateDifference.Hours } hour(s) remained";
                        default:
                        {
                            switch (dateDifference)
                            {
                                case { Minutes: >= 1 }:
                                    return $"{ dateDifference.Minutes } minute(s) remained";
                                default:
                                {
                                    if (dateDifference.TotalSeconds >= 1)
                                        return $"{ dateDifference.Seconds } second(s) remained";
                                    break;
                                }
                            }

                            break;
                        }
                    }

                    break;
                }
            }

            return "Expired!";
        }

        public static string CalculateExpirationTime2(DateTime expiryDate)
        {
            var currentDate = DateTime.Now;
            var dateDifference = expiryDate - currentDate;

            if (dateDifference.Days >= 1)
                return $"{ dateDifference.Days } day(s) remained";
            else if (dateDifference.Hours >= 1)
                return $"{ dateDifference.Hours } hour(s) remained";
            else if (dateDifference.Minutes >= 1)
                return $"{ dateDifference.Minutes } minute(s) remained";
            else if (dateDifference.TotalSeconds >= 1)
                return $"{ dateDifference.Seconds } second(s) remained";

            return "Expired!";
        }

        /// <summary>
        /// Conditionally format TimeSpan dependent on if there are days, hours, minutes.
        /// Does not handle years and milliseconds
        /// </summary>
        /// <param name="span"><see cref="TimeSpan"/> from two dates</param>
        /// <returns>Formatted string</returns>
        public static string FormatElapsed(this TimeSpan span) => span.Days switch
        {
            > 0 => $"{span.Days} days, {span.Hours} hours, {span.Minutes} minutes, {span.Seconds} seconds",
            _ => span.Hours switch
            {
                > 0 => $"{span.Hours} hours, {span.Minutes} minutes, {span.Seconds} seconds",
                _ => span.Minutes switch
                {
                    > 0 => $"{span.Minutes} minutes, {span.Seconds} seconds",
                    _ => span.Seconds switch
                    {
                        > 0 => $"{span.Seconds} seconds",
                        _ => ""
                    }
                }
            }
        };
    }
}