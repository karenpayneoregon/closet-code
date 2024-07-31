using System.Windows.Forms;
using EnumDescriptions.Classes;
#pragma warning disable CS8600
#pragma warning disable CS8619
#pragma warning disable CS8605

namespace EnumDescriptions.Extensions
{
    public static class Extensions
    {
        
        /// <summary>
        /// Hard-wired to get <see cref="Categories"/>
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static (string text, Categories category) CurrentCategory(this ListControl source)
            => (source.Text, (Categories)source.SelectedValue);

        /// <summary>
        /// Generic of above
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static (string text, T item) Current<T>(this ListControl source)
            => (source.Text, (T)source.SelectedValue);

    }
}