using System.Text.RegularExpressions;
using TransformingConsoleCodeSample.Interfaces;

namespace TransformingConsoleCodeSample.LanguageExtensions
{
    public static class Extensions
    {
        public static TResult[] Transform<TSource, TResult>(this TSource[] source, ITransformer<TSource, TResult> transformer)
        {
            if (source == null || transformer == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            var res = Array.ConvertAll(source, transformer.Transform);

            return res;
        }

        public static string SplitCamelCase(this string sender) =>
            string.Join(" ", Regex.Matches(sender, @"([A-Z][a-z]+)")
                .Select(m => m.Value));
    }
}