using System.Collections;
using System.Linq;

namespace SequenceIssues.LanguageExtensions
{
    /// <summary>
    /// Several specific extensions to work with specific collections which may be missing
    /// elements in a sequence
    /// </summary>
    /// <remarks>
    /// Rarely if ever needed yet when needed they are ready to go.
    /// </remarks>
    public static class SequenceExtensions
    {
        /// <summary>
        /// Get missing elements
        /// </summary>
        /// <param name="sequence"></param>
        /// <returns>missing elements</returns>
        /// <remarks>Run <seealso cref="IsSequenceBroken"/> first to determine if elements are missing</remarks>
        public static IEnumerable SequenceFindMissing(this int[] sequence)
        {
            return sequence.Zip(sequence.Skip(1), (valueLeft, valueRight)
                => Enumerable.Range(valueLeft + 1, (valueRight - valueLeft) - 1)).SelectMany(item => item);
        }

        /// <summary>
        /// Determine if the sequence has missing elements
        /// </summary>
        /// <param name="sequence">int array</param>
        /// <returns>true if missing elements, false if no missing elements</returns>
        public static bool IsSequenceBroken(this int[] sequence)
        {
            return sequence.Zip(sequence.Skip(1), (valueLeft, valueRight)
                => valueRight - valueLeft).Any(item => item != 1);
        }


    }
}