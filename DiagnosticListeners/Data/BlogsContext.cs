using DiagnosticListeners.Models;
using Microsoft.EntityFrameworkCore;

namespace DiagnosticListeners.Data
{
    public class BlogsContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EF;Trusted_Connection=True");


        public DbSet<Blog> Blogs { get; set; }
    }
}