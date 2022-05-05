using System;
using System.Diagnostics;
using System.Threading.Tasks;
using MockingPeopleLibrary.Data;
using MockingPeopleLibrary.Extensions;

namespace MockingPeopleLibrary.Classes
{
    public class CreateOperations
    {

        public static async Task<(bool success, Exception exception)> NewPeopleDatabase()
        {

            try
            {
                await using var context = new PersonContext();
                await context.Database.EnsureDeletedAsync();
                await context.Database.EnsureCreatedAsync();

                return (true, null);

            }
            catch (Exception e)
            {

                return (false, e);

            }
        }

        public static async Task<(bool success, Exception exception)> CheckDatabaseExists()
        {
            await using var context = new PersonContext();

            var (success, exception) = await context.CanConnectAsync();
            return (success, exception);
        }
    }
}
