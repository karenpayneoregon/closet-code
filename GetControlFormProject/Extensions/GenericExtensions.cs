using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GetControlFormProject.Extensions
{
    public static class GenericExtensions
    {
        public static IEnumerable<T> Descendants<T>(this Control control) where T : class
        {
            foreach (Control child in control.Controls)
            {
                if (child is T thisControl)
                {
                    yield return (T)thisControl;
                }

                if (child.HasChildren)
                {
                    foreach (T descendant in Descendants<T>(child))
                    {
                        yield return descendant;
                    }
                }
            }
        }

        public static List<TextBox> TextBoxList(this Control control)
            => control.Descendants<TextBox>().ToList();

        public static List<TabControl> TabControlList(this Control control)
            => control.Descendants<TabControl>().ToList();

        public static List<CheckBox> CheckBoxList(this Control control)
            => control.Descendants<CheckBox>().ToList();

        public static string DigitsOnly(this string source) => Regex.Match(source, @"\d+").Value;

    }
}
