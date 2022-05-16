using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using FilteredInclude.Classes;
using FilteredInclude.Data;
using FilteredInclude.LanguageExtensions;
using FilteredInclude.Models;
using FilteredIncludeUnitTestProject.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace FilteredIncludeUnitTestProject
{
    [TestClass]
    public partial class MainTest : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.PlaceHolder)]
        public void SimpleGetAnyOrdersIsDeletedTest()
        {
            // arrange

            using var context = new NorthWindContext();
            // act

            var results = context.Customers
                .Include(customer => customer.Orders)
                .ThenInclude(order => order.OrderDetails)
                .ThenInclude(x => x.Product)
                .Where(x => x.Orders.Any(o => o.IsDeleted.Value)).ToList();

            foreach (var result in results)
            {
                Console.WriteLine($"{result.CustomerIdentifier, -5}");
                foreach (var order in result.Orders)
                {
                    Console.WriteLine($"\t{order.OrderID}");
                    foreach (var detail in order.OrderDetails)
                    {
                        Console.WriteLine($"\t\t{detail.Product.ProductName,-8}{detail.Product.ProductName}");
                    }
                }
            }
            // assert
        }
        [TestMethod]
        [TestTraits(Trait.PlaceHolder)]
        public void GetOrdersFilterIncludeTest()
        {

            using var context = new NorthWindContext();


            /*
             * Returns three customers 👍
             * Returns incorrect order count 👎
             * And incorrect orders
             */
            var example1 = context.Customers
                .Where(c => c.Orders.Any(o => o.IsDeleted.Value))
                .Include(c => c.Orders)
                .ThenInclude(order => order.OrderDetails)
                .ThenInclude(orderDetails => orderDetails.Product)
                .ToList();

            Console.WriteLine($"Example 1 count {example1.Count}");
            int[] expected = new[] { 10258, 10336, 10319 };

            //Check.That(orderIdentifiers).ContainsExactly(expected);
            

            foreach (var customers in example1)
            {
                Console.WriteLine(customers.CompanyName);
                foreach (var order in customers.Orders)
                {
                    Console.WriteLine($"Order # {order.OrderID}");
                    Console.WriteLine($"\t\tIs deleted? {order.IsDeleted.Value.ToYesNo()}");
                    foreach (var detail in order.OrderDetails)
                    {
                        Console.WriteLine($"\t\t\t{detail.Product.ProductName}");
                    }
                }
            }


            // all records 👎
            var example3 = context.Customers
                .Include(c => c.Orders.Where(o => !o.IsDeleted.Value)).ToList();
            Console.WriteLine($"Example 3 count {example3.Count}");


            Console.WriteLine();

            List<IEnumerable<Orders>> filteredOnIsDeletedCustomers = context.Customers
                .Where(customer => customer.Orders.Any(order => order.IsDeleted.Value))
                .Include(customer => customer.Orders.Where(order => order.IsDeleted.Value == true))
                .ThenInclude(order => order.OrderDetails)
                .ThenInclude(orderDetails => orderDetails.Product)
                .Select(customer => customer.Orders.Where(order => order.IsDeleted.Value)).ToList();

            Console.WriteLine($"The following is correctly done ✔: count {filteredOnIsDeletedCustomers.Count}");

            foreach (IEnumerable<Orders> parent in filteredOnIsDeletedCustomers)
            {
                
                foreach (Orders od in parent)
                {
                    Console.WriteLine(od.OrderID);
                    foreach (OrderDetails detail in od.OrderDetails)
                    {
                        Console.WriteLine($"\t{detail.Product}");
                    }
                }

        

            }

        }

        [TestMethod]
        [TestTraits(Trait.PlaceHolder)]
        public void BetweenDates()
        {
            using var context = new NorthWindContext();

            var lowDate = new DateTime(2014, 4, 7);
            var highDate = new DateTime(2014, 7, 8);

            var results = context.Orders
                .WhereDatesBetween(lowDate, highDate)
                .Where(order => order.Freight >10m)
                .ToList();

            foreach (var order  in results)
            {
                Console.WriteLine(order.Freight.Value.ToString("C"));
            }
        }

    }
}
