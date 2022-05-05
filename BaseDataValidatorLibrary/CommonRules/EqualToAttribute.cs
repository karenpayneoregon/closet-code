using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace BaseDataValidatorLibrary.CommonRules
{
    /// <summary>
    /// Validates that the property has the same value as the given 'otherProperty' 
    /// </summary>
    /// <remarks>
    /// https://github.com/srkirkland/DataAnnotationsExtensions/blob/master/DataAnnotationsExtensions/EqualToAttribute.cs
    ///
    /// KP Basic the same as <see cref="CompareAttribute"/>
    /// </remarks>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class EqualToAttribute : ValidationAttribute
    {
        public EqualToAttribute(string otherProperty)
        {
            OtherProperty = otherProperty ?? throw new ArgumentNullException("otherProperty");
            OtherPropertyDisplayName = null;
        }

        public string OtherProperty { get; private set; }

        public string OtherPropertyDisplayName { get; set; }

        public override string FormatErrorMessage(string name)
        {
            if (ErrorMessage == null && ErrorMessageResourceName == null)
            {
                ErrorMessage = "'{0}' and '{1}' do not match.";
            }

            var otherPropertyDisplayName = OtherPropertyDisplayName ?? OtherProperty;

            return string.Format(CultureInfo.CurrentCulture, ErrorMessageString, name, otherPropertyDisplayName);
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var memberNames = new[] { validationContext.MemberName };

            PropertyInfo otherPropertyInfo = validationContext.ObjectType.GetProperty(OtherProperty);
            if (otherPropertyInfo == null)
            {
                return new ValidationResult(string.Format(CultureInfo.CurrentCulture, "Could not find a property named {0}.", OtherProperty), memberNames);
            }

            if (otherPropertyInfo.GetCustomAttributes(typeof(DisplayAttribute), false).FirstOrDefault() is DisplayAttribute displayAttribute && !string.IsNullOrWhiteSpace(displayAttribute.Name))
            {
                OtherPropertyDisplayName = displayAttribute.Name;
            }

            object otherPropertyValue = otherPropertyInfo.GetValue(validationContext.ObjectInstance, null);

            if (!Equals(value, otherPropertyValue))
            {
                return new ValidationResult(FormatErrorMessage(validationContext.DisplayName), memberNames);
            }

            return null;
        }
    }
}