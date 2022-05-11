using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDataValidatorLibrary.CommonRules
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class ExistingFileNameAttribute : ValidationAttribute
    {
        private const string DefaultFileNotFoundMessage = "Sorry but there is already an image with this name please rename your image";
        private const string DefaultErrorMessage = "Please enter a name for your image";

        public string FileNotFoundMessage { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is not null)
            {
                var result = File.Exists(value.ToString()) ? 
                    new ValidationResult(FileNotFoundMessage ?? DefaultFileNotFoundMessage) : 
                    ValidationResult.Success;

                return result;
            }
            else
            {
                var result = new ValidationResult(ErrorMessage ?? DefaultErrorMessage);
                return result;
            }
        }
    }
}
