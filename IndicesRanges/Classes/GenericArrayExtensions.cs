using System.Collections.Generic;
using System.Linq;

namespace IndicesRanges.Classes
{
    public static class GenericArrayExtensions
    {
        public static IEnumerable<T> Add<T>(this IEnumerable<T> sequence, T item) => (sequence ?? Enumerable.Empty<T>()).Concat(new[] { item });
        public static T[] AddToArray<T>(this T[] sequence, T item) => Add(sequence, item).ToArray();
    }
}
