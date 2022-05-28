using System;
using System.Linq;
using HasConversion.Data;
using HasConversion.Models;

namespace HasConversion.Classes
{
    public class WineOperations
    {
        public static void Add(bool reCreate = false)
        {
            using var context = new WineContext();
            
            if (reCreate)
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }

            //context.Wines.Add(new Wine
            //{
            //    Name = "Veuve Clicquot Rose",
            //    WineVariantId = WineVariantId.Rose,
            //});

            //context.Wines.Add(new Wine
            //{
            //    Name = "Whispering Angel Rose",
            //    WineVariantId = WineVariantId.Rose,
            //});

            //context.Wines.Add(new Wine
            //{
            //    Name = "Pinot Grigio",
            //    WineVariantId = WineVariantId.White,
            //});

            context.SaveChanges();

            var all = context.Wines.ToList();

            foreach (var wine in all)
            {
                Console.WriteLine($"{wine.WineVariantId,-10}{wine.Name}");
            }

            Console.WriteLine();

            var rose = context.Wines.Where(x => x.WineVariantId == WineVariantId.Rose).ToList();

            Console.WriteLine("Rose");
            foreach (var wine in rose)
            {
                Console.WriteLine($"\t{wine.Name}");
            }

            Console.WriteLine("Red");
            var red = context.Wines.Where(x => x.WineVariantId == WineVariantId.Red).ToList();
            foreach (var wine in red)
            {
                Console.WriteLine($"\t{wine.Name}");
            }


        }

    }
}
