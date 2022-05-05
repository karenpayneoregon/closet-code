using NFluent;

namespace FluentValidationLibrary.LanguageExensions
{
    public static class FluentExtensions
    {
        /// <summary>
        /// Provides entry point to NFluent checks using extension syntax
        /// </summary>
        /// <param name="sender">the system under test</param>
        /// <typeparam name="T">Type of the system under test.</typeparam>
        /// <returns>an Instance of <see cref="ICheck{T}"/></returns>
        public static ICheck<T> ModelIsValid<T>(this T sender)
        {
            return Check.That(sender);
        }
    }
}
