using System;
using System.Collections.Generic;
using System.Globalization;

namespace GetControlFormProject.Classes
{

    /// <summary>
    /// For sorting strings with numbers <see cref="IComparer{T}"/>
    /// </summary>
    public class SemiNumericComparer : IComparer<string>
    {
        /// <summary>
        /// Method to determine if a string is a number
        /// </summary>
        /// <param name="value">String to test</param>
        /// <returns>True if numeric</returns>
        public static bool IsNumeric(string value) => int.TryParse(value, out _);

        /// <inheritdoc />
        public int Compare(string value1, string value2)
        {
            const int S1GreaterThanS2 = 1;
            const int S2GreaterThanS1 = -1;

            var IsNumeric1 = IsNumeric(value1);
            var IsNumeric2 = IsNumeric(value2);

            if (IsNumeric1 && IsNumeric2)
            {
                var i1 = Convert.ToInt32(value1);
                var i2 = Convert.ToInt32(value2);

                if (i1 > i2)
                {
                    return S1GreaterThanS2;
                }

                if (i1 < i2)
                {
                    return S2GreaterThanS1;
                }

                return 0;
            }

            if (IsNumeric1)
            {
                return S2GreaterThanS1;
            }

            if (IsNumeric2)
            {
                return S1GreaterThanS2;
            }

            return string.Compare(value1, value2, true, CultureInfo.InvariantCulture);
        }
    }
}