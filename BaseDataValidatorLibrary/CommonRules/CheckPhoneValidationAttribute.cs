using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BaseDataValidatorLibrary.CommonRules
{
    /// <summary>
    /// Provides custom rule for phone number rather than using stock [Phone] class
    /// </summary>
    public class CheckPhoneValidationAttribute : ValidationAttribute 
    {
        public override bool IsValid(object sender)
        {
            static bool IsDigitsOnly(string value)
            {
                return value.All(character => character is >= '0' and <= '9');
            }

            if (sender == null)
            {
                return false;
            }

            string convertedValue = sender.ToString();

            return !string.IsNullOrWhiteSpace(convertedValue) && 
                   IsDigitsOnly(convertedValue) && 
                   convertedValue.Length <= 10;
        }
    }
}