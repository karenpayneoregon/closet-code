using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsWhenApp.Classes
{
    public class WebOperations
    {
        /// <summary>
        /// Example using a 'when' to filer a condition, in this case for
        /// a specific type of <see cref="HttpRequestException"/> base on the
        /// exception text.
        /// </summary>
        /// <returns></returns>
        public static async Task<string> MakeRequestWithWhenFilter(string address = "https://localHost:10000")
        {
            var client = new HttpClient();
            var streamTask = client.GetStringAsync(address);
            try
            {
                var responseText = await streamTask;
                return responseText;
            }
            catch (HttpRequestException e) when (e.Message.Contains("301"))
            {
                return "Site Moved";
            }
            catch (HttpRequestException e) when (e.Message.Contains("404"))
            {
                return "Page Not Found";
            }
            catch (HttpRequestException e)
            {
                return e.Message;
            }
        }
    }
}
