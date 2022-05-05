using System;
using System.Linq;

namespace CharacterOccurrencesApp.Classes
{
    public static class NumericArrays
    {
        /// <summary>
        /// Determine if all values can represent an int
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static bool AllInt(this string[] sender)
            => sender.SelectMany(item => item.ToCharArray()).All(char.IsNumber);

        /// <summary>
        /// Given a string array, convert to a int array.
        /// If a element can not be converted the default value is 0.
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static int[] AsIntegerArray(this string[] sender)
            => sender.ToIntegerArray();

        /// <summary>
        /// Convert values in array to int array discards non int values in array.
        /// </summary>
        /// <param name="sender">string array</param>
        /// <returns>All valid elements that are int discarding non int values</returns>
        public static int[] ToIntegerArray(this string[] sender)
        {

            var intArray = Array
                .ConvertAll(sender,
                    (input) => new
                    {
                        IsInteger = int.TryParse(input, out var integerValue),
                        Value = integerValue
                    })
                .Where(result => result.IsInteger)
                .Select(result => result.Value)
                .ToArray();

            return intArray;

        }
    }
}
