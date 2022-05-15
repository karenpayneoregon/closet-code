using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.LanguageExtensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Format a TimeSpan with AM PM
        /// </summary>
        /// <param name="sender">TimeSpan to format</param>
        /// <param name="format">Optional format</param>
        /// <returns></returns>
        public static string Formatted(this TimeSpan sender, string format = "hh:mm tt") =>
            DateTime.Today.Add(sender).ToString(format);
        /// <summary>
        /// Combine date and time
        /// </summary>
        /// <param name="day">Valid Initialized DateTime</param>
        /// <param name="time">Valid initialized TimeSpan</param>
        /// <returns>Day with Time</returns>
        public static DateTime At(this DateTime day, TimeSpan time)
        {
            return (new DateTime(day.Year, day.Month, day.Day, 0, 0, 0)).Add(time);
        }

        public static DateTime RoundedQuarterly(this DateTime sender)
        {
            return new DateTime(sender.Year, sender.Month, sender.Day, sender.Hour, (sender.Minute / 15) * 15, 0);
        }

        public static DateTime RoundedUpHour(this DateTime sender)
        {
            return DateTime.Parse($"{((sender.Minute > 30) ? sender.AddHours(1) : sender):yyyy-MM-dd HH:00:00}");
        }

        /// <summary>
        /// Format a TimeSpan hh:mm tt
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static string CurrentHour(this TimeSpan sender)
        {

            var time = new TimeSpan(0, sender.Hours, 0, 0);
            string TimeIn12Hours = DateTime.MinValue.AddHours(time.Hours).AddMinutes(time.Minutes).ToString("hh:mm tt");


            return TimeIn12Hours;

        }

    }
}
