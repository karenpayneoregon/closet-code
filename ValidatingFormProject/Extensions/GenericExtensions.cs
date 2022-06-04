using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Country = ValidatingFormProject.Models.Country;
using Customer = ValidatingFormProject.Models.Customer;

namespace ValidatingFormProject.Extensions
{
    public static class GenericExtensions
    {
        /// <summary>
        /// Keeps code in form clean, generally not recommended to pass an entire control
        /// </summary>
        public static Country Country(this ComboBox sender)
            => (Country)sender.SelectedItem;

        /// <summary>
        /// Present fake data to Visual Studio's output window
        /// </summary>
        /// <param name="sender"></param>
        public static void DumpJson(this object sender)
        {
            Debug.WriteLine(sender.DumpString());
        }
        public static string DumpString(this object sender)
            => JsonConvert.SerializeObject(sender, Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        public static void ToggleShow(this TextBox sender, bool show = true)
        {
            sender.PasswordChar = show ?
                '\0' :
                '\u25CF';
        }
        public static bool IsNull(this object sender)
        {
            return sender == null || sender == DBNull.Value || Convert.IsDBNull(sender) == true;
        }

        /// <summary>
        /// Is the instance of a class null
        /// </summary>
        /// <typeparam name="T">Concrete class type</typeparam>
        /// <param name="senderInstance">Instance of concrete class</param>
        /// <returns>True if null, false if not null</returns>
        public static bool IsNull<T>(this T senderInstance) where T : new() => senderInstance is null;

        /// <summary>
        /// Is the instance of a class not null
        /// </summary>
        /// <typeparam name="T">Concrete class type</typeparam>
        /// <param name="senderInstance">Instance of concrete class</param>
        /// <returns>True if not null, false if null</returns>
        public static bool IsNotNull<T>(this T senderInstance) where T : new() => !senderInstance.IsNull();

        public static Customer Customer(this BindingSource bindingSource) => (Customer)bindingSource.Current;
    }
}
