using System.ComponentModel.DataAnnotations;

namespace SimpleEmailValidationDataAnnotations.Classes
{
    public class Annotate
    {
        public static bool ValidEmail(string emailAddress) 
            => new EmailAddressAttribute().IsValid(emailAddress);
    }
}
