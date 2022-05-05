using EntityFrameworkCoreHelpers.Classes;
using Microsoft.EntityFrameworkCore;
using MockingPeopleLibrary.Models;

namespace MockingPeopleLibrary.Data
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }

        /// <summary>
        /// Connection string is retrieved via the NuGet package EntityFrameworkCoreHelpers
        /// https://www.nuget.org/packages/EntityFrameworkCoreHelpers/
        ///
        /// Connection string is in MockingPeopleFrontEnd appsettings.json
        /// 
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DbContextConnections.NoLogging(optionsBuilder);
        }

      
    }
}
