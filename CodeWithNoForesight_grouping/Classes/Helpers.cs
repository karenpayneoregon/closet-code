using Microsoft.EntityFrameworkCore;

namespace CodeWithNoForesight_grouping.Classes
{
    public class Helpers
    {
        /// <summary>
        /// Recreate or create database and schema
        /// </summary>
        /// <param name="context"></param>
        public static void CleanDatabase(DbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
