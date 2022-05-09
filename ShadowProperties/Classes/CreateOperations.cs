
using System;
using System.Threading.Tasks;
using ShadowProperties.Data;

namespace ShadowProperties.Classes
{
    public class CreateOperations
    {
        public static async Task<(bool success, Exception exception)> NewDatabase()
        {

            try
            {
                await using var context = new ShadowContext();
                await context.Database.EnsureDeletedAsync();
                await context.Database.EnsureCreatedAsync();

                return (true, null);

            }
            catch (Exception localException)
            {

                return (false, localException);

            }
        }
    }
}
