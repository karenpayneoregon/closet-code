using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace MockingPeopleLibrary.Extensions
{
    /// <summary>
    /// These extensions are dangerous because any object can use
    /// them and that is not wise but for demonstration we are good.
    /// </summary>
    public static class ExtensionsForTesting
    {
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
    }
}