using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using MockingPeopleLibrary.Data;

namespace MockingPeopleLibrary.Classes
{
    /// <summary>
    /// Code here was slapped together quickly
    /// </summary>
    public class VariousExamples
    {
        /// <summary>
        /// Determine if database exists
        /// This can also be done with generics
        /// </summary>
        /// <returns></returns>
        public static async Task<bool> DatabaseExistsAsync()
        {
            await using var context =  new PersonContext();
            return await (context.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).ExistsAsync();
        }

        /// <summary>
        /// WIP
        /// </summary>
        /// <param name="modelName"></param>
        public static void WorkInProgress(string modelName)
        {
            using var context = new PersonContext();
            var item = context.Model
                .GetEntityTypes()
                .FirstOrDefault(et => et.Name == modelName);

            var entityTypes = context.Model
                .GetEntityTypes().Select(et => et.ClrType)
                .ToList();
        }

        /// <summary>
        /// Determine if all tables have records
        /// </summary>
        /// <returns></returns>
        public static bool TablesArePopulated()
        {
            using var cn = new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=EF.People;Trusted_Connection=True");
            using var cmd = new SqlCommand("SELECT T.name TableName,i.Rows NumberOfRows FROM sys.tables T JOIN sys.sysindexes I ON T.OBJECT_ID = I.ID WHERE indid IN (0,1) ORDER BY i.Rows DESC,T.name", cn);

            DataTable table = new DataTable();
            cn.Open();

            table.Load(cmd.ExecuteReader());
            return table.AsEnumerable()
                .All(row => row.Field<int>("NumberOfRows") > 0);
            
        }
    }
}
