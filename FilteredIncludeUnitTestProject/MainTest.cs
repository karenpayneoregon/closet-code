﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
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
                .Where(customer => customer.Orders.Any(order => order.IsDeleted.Value))
                .Include(customer => customer.Orders)
                .ThenInclude(order => order.OrderDetails)
                .ThenInclude(orderDetails => orderDetails.Product)
                .ToList();

            Console.WriteLine($"Example 1 count {example1.Count}");
           

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

            // This is best done with Global Query Filters
            List<IEnumerable<Orders>> filteredOnIsDeletedCustomers = context.Customers
                .Where(customer => customer.Orders.Any(order => order.IsDeleted.Value))
                .Include(customer => customer.Orders.Where(order => order.IsDeleted.Value == true))
                .ThenInclude(order => order.OrderDetails)
                .ThenInclude(orderDetails => orderDetails.Product)
                .Select(customer => customer.Orders.Where(order => order.IsDeleted.Value)).ToList();

            Console.WriteLine($"The following is correctly done ✔: count {filteredOnIsDeletedCustomers.Count}");
            StringBuilder builder = new();
            foreach (IEnumerable<Orders> orders in filteredOnIsDeletedCustomers)
            {
                
                foreach (Orders order in orders)
                {

                    builder.AppendLine(order.OrderID.ToString());
                    foreach (OrderDetails detail in order.OrderDetails)
                    {
                        builder.AppendIndented(detail.Product.ProductName);
                    }
                }
            }

            Console.WriteLine(builder);

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


            foreach (var order in results)
            {
                Console.WriteLine(order.Freight.Value.ToString("C"));
            }

            Console.WriteLine();

            var ordersList = context.Orders
                .Between(x => x.OrderDate.Value, lowDate, highDate)
                .Where(order => order.Freight > 10m)
                .ToList();

            foreach (var order in ordersList)
            {
                if (order.Freight != null) Console.WriteLine(order.Freight.Value.ToString("C"));
            }


            var productsList = context.Products.Between(p => p.UnitsInStock.Value, 0, 13).ToList();
            Console.WriteLine(productsList.Count);
        }

        [TestMethod]
        [TestTraits(Trait.PlaceHolder)]
        public async Task Setup()
        {
            await Task.Delay(0);
            var (success, exception) = await CreateOperations.NewDatabase();
            Console.WriteLine(success);
            CreateOperations.CreateProducts();
            CreateOperations.CreateCustomers();
            CreateOperations.CreateOrders();
        }

    }
}