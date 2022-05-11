using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
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
        public static async Task<(bool success, bool generalException, Exception exception)> Connect(CancellationToken cancellationToken)
        {

            try
            {
                await using var cn = new SqlConnection(ConnectionString());
                await cn.OpenAsync(cancellationToken);
                return (true, false, null);
            }
            catch (TaskCanceledException tce)
            {
                return (false,false, tce);
            }
            catch (Exception localException)
            {
                return (false, true, localException);
            }

        }
    }
}
