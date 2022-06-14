using System.Text.RegularExpressions;

namespace AccountsLibrary.Classes
{
    /// <summary>
    /// Not used in this project but could be used for creating new accounts
    /// </summary>
    public class Utilities
    {
        public static string NextValue(string sender)
        {
            string value = Regex.Match(sender, "[0-9]+$").Value;
            return sender[..^value.Length] + (long.Parse(value) + 1)
                .ToString().PadLeft(value.Length, '0');
        }
    }
}