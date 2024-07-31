using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using static System.Globalization.DateTimeFormatInfo;
using static System.DateTime;

namespace CommonLibrary.Classes
{
	/// <summary>
	/// Date time Globalization methods
	/// </summary>
	public class DateTimeHelpers
	{
		/// <summary>
		/// Returns a string list of month names for the current culture
		/// </summary>
		/// <returns>
		/// List of month names for current culture
		/// </returns>
		public static List<string> MonthNames() 
            => CurrentInfo!.MonthNames[..^1].ToList();

		/// <summary>
		/// Returns a list of month names for a specific culture
		/// </summary>
		/// <param name="languageCode">language code to get month names for</param>
		/// <returns>
		/// List of month names for specified culture or runtime error if not a valid culture
		/// </returns>
		/// <remarks>
		/// If the current culture is EN ??? may be displayed but not via Debug.WriteLine
		/// Helpers.MonthNames("ru-RU").ForEach(m => Debug.WriteLine(m));
		/// 
		/// </remarks>
		public static List<string> MonthNames(string languageCode) 
            => Enumerable.Range(1, 12)
                .Select((index) => (new CultureInfo(languageCode))
                    .DateTimeFormat.GetMonthName(index)).ToList();

		/// <summary>
		/// Returns a string list of day names for the current culture
		/// </summary>
		/// <returns>
		/// Day names for current culture
		/// </returns>
		public static List<string> DayNames() 
            => CurrentInfo.DayNames.ToList();

		/// <summary>
		/// Returns a list of day names for a specific culture
		/// </summary>
		/// <param name="languageCode">language code to get month names for</param>
		/// <returns>list of day names for specific culture</returns>
		public static List<string> DayNames(string languageCode) 
            => (new CultureInfo(languageCode)).DateTimeFormat.DayNames.ToList();

		/// <summary>
		/// Vietnamese day names
		/// </summary>
		/// <returns></returns>
		public static List<string> RussianDayNames() 
            => DayNames("ru-RU");

        public static List<string> RussianMonthNames()
            => MonthNames("ru-RU");

		/// <summary>
		/// Russian day names
		/// </summary>
		/// <returns></returns>
		public static List<string> VietnameseDayNames() 
            => DayNames("vie");

		/// <summary>
		/// Spanish day names
		/// </summary>
		/// <returns></returns>
		public static List<string> SpanishDayNames() 
            => DayNames("es");

		/// <summary>
		/// Gets the string designator for hours that are before noon. for current culture
		/// </summary>
		/// <returns></returns>
		/// <remarks>
		/// Make this non read-only to have a setter
		/// </remarks>
		public static string AmDesignator 
            => CurrentInfo!.AMDesignator;

		/// <summary>
		/// Gets or sets the string designator for hours that are  (after noon).
		/// </summary>
		/// <returns></returns>
		/// <remarks>
		/// Make this non read-only to have a setter
		/// </remarks>
		public static string PmDesignator 
            => CurrentInfo.PMDesignator;

		/// <summary>
		/// Determine if morning
		/// </summary>
		/// <returns></returns>
		public static bool IsMorning 
            => Now.Hour <= 12;

        /// <summary>
		/// Is it afternoon currently
		/// </summary>
		public static bool IsAfternoon 
            => Now.Hour is <= 16 and > 12;

        /// <summary>
		/// 
		/// </summary>
		public static bool IsEvening 
            => Now.Hour is <= 20 and > 16;

		public static string TimeOfDay() =>
            Now.Hour switch
            {
                <= 12 => "Good Morning",
                <= 16 => "Good Afternoon",
                <= 20 => "Good Evening",
                _ => "Good Night"
            };


	}

}
