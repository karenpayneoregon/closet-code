using System;
using System.Collections.Generic;
using System.Linq;

namespace CommonLibrary.Classes
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Get random list of <see cref="T"/>
        /// </summary>
        /// <typeparam name="T">type</typeparam>
        /// <param name="source">valid source of <see cref="T"/></param>
        /// <returns>shuffled list</returns>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
            => source.Shuffle(new Random());

        /// <summary>
        /// Assertions
        /// </summary>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source, Random random)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (random == null) throw new ArgumentNullException(nameof(random));

            return source.ShuffleIterator(random);
        }

        /// <summary>
        /// Get list
        /// </summary>
        private static IEnumerable<T> ShuffleIterator<T>(this IEnumerable<T> source, Random rng)
        {
            List<T> buffer = source.ToList();

            for (int index = 0; index < buffer.Count; index++)
            {
                int next = rng.Next(index, buffer.Count);
                yield return buffer[next];

                buffer[next] = buffer[index];
            }

        }
    }
}