using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BaseDataValidatorLibrary.Classes;
using BaseDataValidatorLibrary.CommonRules;

// ReSharper disable once CheckNamespace
namespace BaseDataValidatorLibrary.Helpers
{
    public static partial class Model
    {
        /// <summary>
        /// Obtain property name and ErrorMessage for properties with a <see cref="RequiredAttribute"/>
        /// </summary>
        /// <typeparam name="T">Type to get messages</typeparam>
        /// <param name="sender">instantiated instance of T</param>
        /// <returns>Dictionary of names and error messages</returns>
        public static Dictionary<string, string> GetRequiredErrorMessages<T>(T sender)
        {
            Dictionary<string, string> dictionary = new();

            var type = typeof(T);
            PropertyInfo[] propertyInfo = type.GetProperties();

            foreach (PropertyInfo prop in propertyInfo)
            {
                object[] attributes = prop.GetCustomAttributes(true);

                foreach (var attribute in attributes)
                {
                    if (attribute is not RequiredAttribute currentAttribute) continue;
                    string propName = prop.Name;
                    string auth = currentAttribute.ErrorMessage;

                    dictionary.Add(propName, auth);
                }
            }

            return dictionary;
        }

        /// <summary>
        /// Provides access to annotation details for <see cref="ValidateYearsAttribute"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static List<ValidateYearsDetails> GetValidateYearsErrorMessages<T>(T sender)
        {

            List<ValidateYearsDetails> list = new();

            var type = typeof(T);
            PropertyInfo[] propertyInfo = type.GetProperties();

            foreach (PropertyInfo prop in propertyInfo)
            {
                object[] attributes = prop.GetCustomAttributes(true);

                foreach (var attribute in attributes)
                {
                    if (attribute is not ValidateYearsAttribute currentAttribute) continue;

                    list.Add(new ValidateYearsDetails()
                    {
                        PropertyName = prop.Name,
                        ErrorMessage = currentAttribute.ErrorMessage,
                        Min = currentAttribute._minValue,
                        Max = currentAttribute._maxValue
                    }
                    );

                }
            }

            return list;
        }
    }
}
