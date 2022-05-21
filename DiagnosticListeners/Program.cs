using System;
using System.Diagnostics;
using System.Linq;
using DiagnosticListeners.Classes;
using DiagnosticListeners.Data;
using DiagnosticListeners.Models;
using Microsoft.EntityFrameworkCore;

namespace DiagnosticListeners
{

    partial class Program
    {
 
        public static void Main()
        {

            DiagnosticListener.AllListeners.Subscribe(new DiagnosticObserver());
   

            using (var context = new BlogsContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                context.Add(
                    new Blog { Name = "EF Blog", Posts = { new Post { Title = "EF Core 3.1!" }, new Post { Title = "EF Core 5.0!" } } });

                context.SaveChanges();
            }

            using (var context = new BlogsContext())
            {
                var blog = context.Blogs.Include(e => e.Posts).Single();

                blog.Name = "EF Core Blog";
                context.Remove(blog.Posts.First());
                blog.Posts.Add(new Post { Title = "EF Core 6.0!" });

                context.SaveChanges();
            }
        

            Console.WriteLine("Finished");
            Console.ReadLine();
        }
    }
}