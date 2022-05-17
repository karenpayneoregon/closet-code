using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using FilteredInclude.Data;
using FilteredInclude.LanguageExtensions;
using FilteredInclude.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace FilteredInclude.Classes
{
    public class CreateOperations
    {
        public static async Task<(bool success, Exception exception)> NewDatabase()
        {

            try
            {
                await using var context = new NorthWindContext();
                await context.Database.EnsureDeletedAsync();
                await context.Database.EnsureCreatedAsync();

                return (true, null);

            }
            catch (Exception localException)
            {

                return (false, localException);

            }
        }

        public static void Populate()
        {
            var customers = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json", "Customers.json")).JSonToList<Customers>();
            Console.WriteLine(customers.Count);
            var orderDetails = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json", "OrderDetails.json")).JSonToList<OrderDetails>();
            Console.WriteLine(orderDetails.Count);

            List<Orders> orders = JsonConvert.DeserializeObject<List<Orders>>(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json", "Orders.json")));
            Console.WriteLine(orders.Count);

            var products = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json", "products.json")).JSonToList<Products>();
            Console.WriteLine(products.Count);


            using var context = new NorthWindContext();
            context.Customers.AddRange(customers);
            //context.OrderDetails.AddRange(orderDetails);
            //context.Orders.AddRange(orders);
            context.Products.AddRange(products);

            context.Database.OpenConnection();
            try
            {
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Products ON");
                //context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Orders ON");
                //context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Customers ON");
                //context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT OrderDetails ON");
                context.SaveChanges();
                //context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Products OFF");
                //context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Orders OFF");
                //context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Customers OFF");
                //context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT OrderDetails OFF");

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                context.Database.CloseConnection();
            }
        }

        public static void CreateProducts()
        {
            var products = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json", "products.json")).JSonToList<Products>();
            Console.WriteLine(products.Count);


            using var context = new NorthWindContext();
            context.Products.AddRange(products);

            context.Database.OpenConnection();
            try
            {
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Products ON");
                context.SaveChanges();
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Products OFF");

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                context.Database.CloseConnection();
            }
        }

        public static void CreateCustomers()
        {
            var customers = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json", "Customers.json")).JSonToList<Customers>();

            using var context = new NorthWindContext();
            context.Customers.AddRange(customers);

            context.Database.OpenConnection();
            try
            {
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Customers ON");
                context.SaveChanges();
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Customers OFF");

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                context.Database.CloseConnection();
            }
        }

        public static void CreateOrders()
        {

            List<Orders> orders = JsonConvert.DeserializeObject<List<Orders>>(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json", "Orders.json")));
            
            using var context = new NorthWindContext();

            context.Orders.AddRange(orders);

            context.Database.OpenConnection();
            try
            {
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Orders ON");
                context.SaveChanges();
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Orders OFF");

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                context.Database.CloseConnection();
            }
        }
    }
}
