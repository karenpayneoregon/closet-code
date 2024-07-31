using System;
using System.Collections.Generic;
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
        /// Given a string array, convert to an int array.
        /// If an element can not be converted the default value is 0.
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

        public static int[] ToIntegerArray(this List<string> sender)
        {

            var intArray = Array
                .ConvertAll(sender.ToArray(),
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
        public static int[] ToIntegerPreserveArray(this List<string> sender)
        {

            var intArray = Array.ConvertAll(sender.ToArray(), (input) =>
            {
                int.TryParse(input, out var integerValue);
                return integerValue;
            });

            return intArray;

        }
        /// <summary>
        /// Get indices in list which can not represent an int
        /// </summary>
        public static int[] GetNonIntegerIndexes(this List<string> sender) =>
            sender.Select(
                    (item, index) => int.TryParse(item, out var tResult) ?
                        new { IsInteger = true, Index = index } :
                        new { IsInteger = false, Index = index })
                .ToArray()
                .Where(item => item.IsInteger == false)
                .Select(item => item.Index).ToArray();
    }


}
