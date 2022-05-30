using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWind2020ConsoleApp.Data;
using NorthWind2020ConsoleApp.Models;
using Spectre.Console;

namespace NorthWind2020ConsoleApp.Classes
{
    public class EmployeeOperations
    {
        /// <summary>
        /// Example for self-referencing table where the property <see cref="Employees.ReportsTo"/> is null
        /// this indicates the <see cref="Employees"/> is a manager.
        ///
        /// <see cref="Employees.WorkersNavigation"/> for a manager will contain their employees.
        /// </summary>
        public static void EmployeeReportsTo()
        {
            using var context = new Context();

            List<Employees> employees = context.Employees.ToList();

            //List<Employees> managers = employees
            //    .Where(employee => !employee.ReportsTo.HasValue)
            //    .ToList();

            //var workers = employees.Where(x => x.ReportsTo.HasValue).ToList();

            List<IGrouping<int?, Employees>> groupedData = employees
                .Where(x => x.ReportsTo.HasValue)
                .ToList()
                .GroupBy(x => x.ReportsTo)
                .ToList();

            var table = CreateViewTable();

            foreach (var group in groupedData)
            {
                var groupKey = group.Key;

                table.AddRow(employees.Find(x => x.EmployeeId == groupKey.Value)!.FullName);

                foreach (var groupedItem in group)
                {
                    table.AddRow("", groupedItem.FullName);
                }
            }

            AnsiConsole.Write(table);

        }

        private static Table CreateViewTable()
        {
            return new Table()
                .Border(TableBorder.Square)
                .BorderColor(Color.Grey100)
                .Title("[yellow][B]Employees[/][/]")
                .AddColumn(new TableColumn("[u]Manager[/]"))
                .AddColumn(new TableColumn("[u]Workers[/]"));
        }

    }
}
