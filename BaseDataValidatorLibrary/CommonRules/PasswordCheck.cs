using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace BaseDataValidatorLibrary.CommonRules
{
    public class PasswordCheck : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var validPassword = false;
            var reason = string.Empty;
            var password = (value == null) ? string.Empty : value.ToString();

            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
            {
                reason = "new password must be at least 6 characters long. ";
            }
            else
            {
                var pattern = new Regex("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})");
                if (!pattern.IsMatch(password))
                {
                    reason += "Your new password must contain at least 1 symbol character and number.";
                }
                else
                {
                    validPassword = true;
                }
            }

            return validPassword;

        }

    }
}