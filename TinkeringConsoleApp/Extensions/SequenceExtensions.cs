using System.Collections.Generic;
using System.Linq;
using TinkeringConsoleApp.Interfaces;

namespace TinkeringConsoleApp.Extensions
{
    /// <summary>
    /// First three extensions perform the same function done slightly different from each other
    /// Last is generic to <see cref="IEmployee"/>
    /// </summary>
    public static class SequenceExtensions
    {
        public static int[] FindMissing(this int[] sequence) =>
            sequence.Zip(sequence.Skip(1), (valueLeft, valueRight)
                    => Enumerable.Range(valueLeft + 1, (valueRight - valueLeft) - 1)).SelectMany(item => item)
                .ToArray();
        public static int[] Missing(this int[] sequence)
            => Enumerable.Range(1, sequence[^1]).Except(sequence)
                .ToArray();

        public static int[] Missing1(this int[] sequence)
            => Enumerable.Range(sequence.First(), sequence.Last()).Except(sequence)
                .ToArray();

        public static int[] MissingIdentifiers(this List<IEmployee> sender)
            => sender.Select(x => x.Id).ToArray().Missing();

    }
}