using System;
using System.Collections.Generic;
using System.Linq;

namespace CommonLibrary.Classes
{
    /// <summary>
    /// Used to create a string array which represent time in a day.
    /// </summary>
    public class Hours
    {
        /// <summary>
        /// Creates an array quarter hours
        /// </summary>
        public  string[] Quarterly => Range(TimeIncrement.Quarterly);
        /// <summary>
        /// Creates an array of hours
        /// </summary>
        public  string[] Hourly => Range();
        /// <summary>
        /// Creates an array of half-hours
        /// </summary>
        public  string[] HalfHour => Range(TimeIncrement.HalfHour);

        public static string TimeFormat { get; set; } = "hh:mm tt";

        public  string[] Range(TimeIncrement pTimeIncrement = TimeIncrement.Hourly)
        {

            IEnumerable<DateTime> hours = Enumerable.Range(0, 24)
                .Select((index) => (DateTime.MinValue.AddHours(index)));

            var timeList = new List<string>();

            foreach (var dateTime in hours)
            {

                timeList.Add(dateTime.ToString(TimeFormat));

                if (pTimeIncrement == TimeIncrement.Quarterly)
                {
                    timeList.Add(dateTime.AddMinutes(15).ToString(TimeFormat));
                    timeList.Add(dateTime.AddMinutes(30).ToString(TimeFormat));
                    timeList.Add(dateTime.AddMinutes(45).ToString(TimeFormat));
                }
                else if (pTimeIncrement == TimeIncrement.HalfHour)
                {
                    timeList.Add(dateTime.AddMinutes(30).ToString(TimeFormat));
                }
            }

            return timeList.ToArray();

        }
    }
}