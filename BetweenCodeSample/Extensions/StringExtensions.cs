namespace BetweenCodeSample.Extensions
{
    public static class StringExtensions
    {
        public static string ToYesNo(this bool value)
            => value ? "Yes" : "No";
    }
}
