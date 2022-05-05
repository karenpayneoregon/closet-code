using System;
using System.ComponentModel.DataAnnotations;

namespace BaseDataValidatorLibrary.CommonRules
{

    /// <summary>
    /// Disallow date to be a weekend date
    /// </summary>
    public class WeekendDateNotPermittedAttribute : ValidationAttribute
    {
        public override bool IsValid(object senderDate)
        {
            DateTime date = Convert.ToDateTime(senderDate);
            return date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;
        }
    }

}