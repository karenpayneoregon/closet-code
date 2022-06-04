using System.Globalization;

namespace DateTimeAmPm.Classes
{
    public class DateTimeHelpers
    {
        public static DateTimeFormatInfo AmDateTimeFormatInfo 
            => new()
            {
                AMDesignator = "a. m.", 
                PMDesignator = "p. m."
            };
    }
}
