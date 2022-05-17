using System.Text;

namespace FilteredIncludeUnitTestProject.Base
{
    public static class Extensions
    {
        public static void AppendIndented(this StringBuilder sender, string value)
        {
            sender.AppendLine($"\t{value}");
        }
    }
}