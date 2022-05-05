using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using static ConfigurationLibrary.Classes.ConfigurationHelper;

namespace SqlServerSimpleConnect.Classes
{
    public class Operations
    {
        /// <summary>
        /// Test if a connection can be made, downside on failure we lose the reason
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<(bool success, Exception exception)> Connect(CancellationToken cancellationToken)
        {
   
            try
            {
                await using var cn = new SqlConnection(ConnectionString());
                await cn.OpenAsync(cancellationToken);
                return (true, null);
            }
            catch (Exception e)
            {
                return (false, e);
            }

        }
    }
}
