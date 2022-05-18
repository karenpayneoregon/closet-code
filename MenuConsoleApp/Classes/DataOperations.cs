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
        /// <summary>
        /// Get all categories from database
        /// </summary>
        /// <returns>array of categories</returns>
        public static Categories[] Categories()
        {
            using var context = new NorthwindContext();
            var list = context.Categories.ToList();
            list.Insert(list.Count, new Categories() {CategoryId = -1, CategoryName = "Exit"});
            return list.ToArray();
        }

        /// <summary>
        /// For main menu
        /// </summary>
        /// <param name="categoryIdentifier">category id to get products</param>
        public static List<Products> ProductsList(int categoryIdentifier)
        {
            using var context = new NorthwindContext();
            return context.Products.Where(product => product.CategoryId == categoryIdentifier).ToList();

        }

        /// <summary>
        /// List of products by category identifier for product menu
        /// </summary>
        /// <param name="categoryIdentifier">category id to get products</param>
        public static Products[] ProductsMenuList(int categoryIdentifier)
        {
            using var context = new NorthwindContext();
            var list = context.Products.Where(product => product.CategoryId == categoryIdentifier).ToList();
            list.Insert(list.Count, new Products() {ProductId = -1, ProductName = "Exit"});
            return list.ToArray();
        }
    }
}
