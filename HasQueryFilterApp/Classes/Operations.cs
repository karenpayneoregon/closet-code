using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ShadowProperties.Data;
using ShadowProperties.Models;
using static ConfigurationLibrary.Classes.ConfigurationHelper;
//using SqlConnection = System.Data.SqlClient.SqlConnection;

namespace HasQueryFilterApp.Classes
{
    public class Operations
    {
        public static void Remove(Contact1 contact1)
        {
            using var context = new ShadowContext();
            context.Add(contact1).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public static async Task<List<Contact1>> Contacts()
        {
            await using var context = new ShadowContext();
            return await context.Contacts1.ToListAsync();
        }

        public static async Task<(int all, int filter)> GetContact1Counts()
        {
            await using var context = new ShadowContext();
            var allRecords = await context.Contacts1.ToListAsync();
            var filterRecords = await context.Contacts1.IgnoreQueryFilters().ToListAsync();

            return (allRecords.Count, filterRecords.Count);
        }

        public static async Task<(bool success, Exception exception)> ResetDeleted()
        {

            try
            {
                await using var cn = new SqlConnection(ConnectionString());
                await using var cmd = new SqlCommand()
                {
                    CommandText = "UPDATE dbo.Contact1 SET isDeleted = 0;", 
                    Connection = cn
                };

                await cn.OpenAsync();
                cmd.ExecuteNonQuery();
                return (true, null);
            }
            catch (Exception e)
            {
                return (false, e);
            }

        }
    }
}
