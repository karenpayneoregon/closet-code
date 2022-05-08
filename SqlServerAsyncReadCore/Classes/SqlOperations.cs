using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SqlServerAsyncReadCore.Classes
{
    public class SqlOperations : Helpers
    {
        private static readonly string _connectionString = ConnectionString();

        public static async Task<(Exception, bool, List<string>)> ReadPlaceholderTask(CancellationToken cancellationToken)
        {
            (Exception, bool, List<string> namesList) result = (null, true, new List<string>());

            var selectStatement = "SELECT CategoryName FROM dbo.Categories WHERE dbo.Categories.CategoryID IN (1,3);";

            return await Task.Run(async () =>
            {

                await using var cn = new SqlConnection(_connectionString);
                await using var cmd = new SqlCommand { Connection = cn, CommandText = selectStatement };

                try
                {
                    await cn.OpenAsync(cancellationToken);
                    var reader = await cmd.ExecuteReaderAsync(cancellationToken);

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync(cancellationToken))
                        {
                            result.namesList.Add(reader.GetString(0));
                        }
                    }


                }
                catch (TaskCanceledException tce)
                {
                    result = (tce, false, null);

                }
                catch (Exception exception)
                {
                    result = (exception, false, null);
                }

                return result;

            }, cancellationToken);
        }


    }
}

