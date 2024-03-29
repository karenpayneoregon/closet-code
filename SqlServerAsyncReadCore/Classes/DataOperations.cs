﻿using System.Data;
using Microsoft.Data.SqlClient;

namespace SqlServerAsyncReadCore.Classes;

public class DataOperations
{
    private static readonly string ConnectionString =
        "Data Source=.\\sqlexpress;Initial Catalog=NorthWind2020;Integrated Security=True;Encrypt=False";

    public static DataTable GetCustomers()
    {
        var cn = new SqlConnection(ConnectionString);
        var cmd = new SqlCommand { 
            Connection = cn, 
            CommandText = 
                """
                SELECT C.CompanyName,
                       CT.FirstName,
                       CT.LastName
                FROM dbo.Customers AS C
                    INNER JOIN dbo.Contacts AS CT
                        ON C.ContactId = CT.ContactId;
                """ };

        cn.Open();
        DataTable table = new DataTable();
        table.Load(cmd.ExecuteReader());
        return table;

    }
    public static async Task<DataTable> ReadProductsTask(CancellationToken cancellationToken)
    {

        return await Task.Run(async () =>
        {
            var productTable = new DataTable();

            await using var cn = new SqlConnection(ConnectionString);
            await using var cmd = new SqlCommand {Connection = cn, CommandText = SelectStatement()};

            try
            {
                await cn.OpenAsync(cancellationToken);
            }
            catch (TaskCanceledException)
            {
                return null;
            }
            catch // consider adapting the return type to tuple and include the exception
            {
                return null;
            }

            productTable.Load(await cmd.ExecuteReaderAsync(cancellationToken));

            return productTable;

        });

    }

    public static async Task<(Exception, bool success, List<object>)> ReadPlaceholderTask(CancellationToken cancellationToken)
    {
        (Exception, bool, List<object>) result = (null, true, new List<object>());

        var selectStatement = "";
            
        return await Task.Run(async () =>
        {

            await using var cn = new SqlConnection(ConnectionString);
            await using var cmd = new SqlCommand { Connection = cn, CommandText = selectStatement };
                
            try
            {
                await cn.OpenAsync(cancellationToken);
                var reader = await cmd.ExecuteReaderAsync(cancellationToken);

                if (reader.HasRows)
                {
                        
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




    #region So there is no guessing when working with data in the form
    /// <summary>
    /// Product table primary key <see cref="ReadProductsTask"/>
    /// </summary>
    public static readonly string PrimaryKey = "ProductID";
    /// <summary>
    /// What to display in CheckedListBox
    /// </summary>
    public static readonly string DisplayColumn = "ProductName";
    #endregion

    /// <summary>
    /// Responsible for reading products in 
    /// </summary>
    /// <returns></returns>
    private static string SelectStatement()
    {
        return $"SELECT P.{PrimaryKey}, P.{DisplayColumn}, P.SupplierID, S.CompanyName, P.CategoryID, " +
               "C.CategoryName, P.QuantityPerUnit, P.UnitPrice, P.UnitsInStock, P.UnitsOnOrder, " +
               "P.ReorderLevel, P.Discontinued, P.DiscontinuedDate " +
               "FROM  Products AS P INNER JOIN Categories AS C ON P.CategoryID = C.CategoryID " +
               "INNER JOIN Suppliers AS S ON P.SupplierID = S.SupplierID";
    }

}