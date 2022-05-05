using System;
using BaseDataValidatorLibrary.CommonRules;
using BaseDataValidatorLibrary.Helpers;

namespace BaseDataValidatorLibrary.Classes
{
    /// <summary>
    /// For obtaining <see cref="ValidateYearsAttribute"/> ErrorMessage
    /// using <see cref="Model.GetValidateYearsErrorMessages(T)"/>
    /// </summary>
    public class ValidateYearsDetails
    {
        /// <summary>
        /// Property name
        /// </summary>
        public string PropertyName { get; set; }
        /// <summary>
        /// Error text for validation 
        /// </summary>
        public string ErrorMessage { get; set; }
        /// <summary>
        /// Rule is on the year, minimum year entered as a date time
        /// </summary>
        public DateTime Min { get; set; }
        /// <summary>
        /// Rule is on the year, maximum year entered as a date time
        /// </summary>
        public DateTime Max { get; set; }
        /// <summary>
        /// for display in local window
        /// </summary>
        /// <returns></returns>
        public override string ToString() => string.Format(ErrorMessage, Min.Year, Max.Year);

    }
}