using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using BaseDataValidatorLibrary.Helpers;

namespace BaseDataValidatorLibrary.LanguageExtensions
{
    public static class ValidatorExtensions
    {

        /// <summary>
        /// List errors if any
        /// </summary>
        /// <param name="sender"><see cref="EntityValidationResult"/></param>
        /// <returns>list of 0 to many error messages</returns>
        public static List<string> ErrorMessagesList(this EntityValidationResult sender)
        {
            string RemoveSpaces(string item) 
                => Regex.Replace(item, @"\s+", " ");
            
            return sender.Errors.Select(validationResult 
                => RemoveSpaces(validationResult.ErrorMessage.SplitCamelCase())).ToList();
        }

        /// <summary>
        /// Displays any error messages using Console.WriteLine
        /// </summary>
        /// <param name="sender"></param>
        public static void ShowErrorMessages(this EntityValidationResult sender)
        {
            
            sender.ErrorMessagesList().ForEach(Console.WriteLine);
            
        }

        public static string ErrorText(this EntityValidationResult sender)
        {
            StringBuilder builder = new();
            sender.ErrorMessagesList().ForEach(x => builder.AppendLine(x));
            return builder.ToString();
        }

    }
}
