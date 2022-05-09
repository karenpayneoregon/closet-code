using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuConsoleApp.Data;
using MenuConsoleApp.Models;

namespace MenuConsoleApp.Classes
{
    public class DataOperations
    {
        public static Categories[] Categories()
        {
            using var context = new NorthwindContext();
            var list = context.Categories.ToList();
            list.Insert(list.Count, new Categories() {CategoryId = -1, CategoryName = "Exit"});
            return list.ToArray();
        }

        public static List<Products> ProductsList(int categoryIdentifier)
        {
            using var context = new NorthwindContext();
            return context.Products.Where(product => product.CategoryId == categoryIdentifier).ToList();

        }
    }
}
