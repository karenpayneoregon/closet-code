using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GetControlFormProject.Classes
{
    public class TextBoxItem
    {
        public string Name { get; }
        public string Text { get; }

        public TextBoxItem(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public override string ToString()
        {
            return $"{Name} = {Text}";
        }

    }

    public class CustomComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            var regex = new Regex("^(d+)");

            // run the regex on both strings
            var xRegexResult = regex.Match(x);
            var yRegexResult = regex.Match(y);

            // check if they are both numbers
            if (xRegexResult.Success && yRegexResult.Success)
            {
                return int.Parse(xRegexResult.Groups[1].Value).CompareTo(int.Parse(yRegexResult.Groups[1].Value));
            }

            // otherwise return as string comparison
            return x.CompareTo(y);
        }
    }
}