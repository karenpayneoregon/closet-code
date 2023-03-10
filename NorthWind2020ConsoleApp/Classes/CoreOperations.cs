using System.Diagnostics.CodeAnalysis;
using NorthWind2020ConsoleApp.Data;
using NorthWind2020ConsoleApp.Models;
using Spectre.Console;
// ReSharper disable PossibleInvalidOperationException

namespace NorthWind2020ConsoleApp.Classes;

public class CoreOperations
{

    /// <summary>
    /// Example for self-referencing table where the property <see cref="Employees.ReportsTo"/> is null
    /// this indicates the <see cref="Employees"/> is a manager.
    ///
    /// <see cref="Employees.WorkersNavigation"/> for a manager will contain their employees.
    /// </summary>
    [SuppressMessage("ReSharper", "All")]
    public static void EmployeeReportsTo()
    {
        using var context = new Context();

        List<Employees> employees = context.Employees.ToList();

        List<IGrouping<int?, Employees>> groupedData = employees
            .Where(employee => employee.ReportsTo.HasValue)
            .ToList()
            .OrderBy(employee => employee.LastName)
            .GroupBy(employee => employee.ReportsTo)
            .ToList();

        var table = CreateViewTable();

        List<Manager> managers = new();

        foreach (var group in groupedData)
        {

            Employees current = employees.Find(employee => employee.EmployeeId == group.Key.Value);
            table.AddRow(current!.FullName);

            Manager manager = new() {Employee = current };

            foreach (var groupedItem in group)
            {
                table.AddRow("", groupedItem.FullName);
                manager.Workers.Add(groupedItem);
            }

            managers.Add(manager);

        }

        managers = managers.OrderBy(x => x.Employee.LastName).ToList();

        AnsiConsole.Write(table);

    }

    /// <summary>
    /// Get list of random records for <see cref="TModel"/> by <see cref="count"/>
    /// </summary>
    /// <typeparam name="TModel">Model to read</typeparam>
    /// <param name="count">Max records</param>
    /// <returns>List of <see cref="TModel"/></returns>
    /// <remarks>
    /// Not guaranteed to return <see cref="count"/> but will return records
    /// </remarks>
    public static List<TModel> Random<TModel>(int count) where TModel : class
    {
        using var context = new Context();

        Random rand = new();
        int skipper = rand.Next(1, context.Set<TModel>().Count());
        return context.Set<TModel>().ToList()
            .OrderBy( _ => Guid.NewGuid())
            .Skip(skipper)
            .Take(count).ToList();
    }

    public static List<Products> RandomProducts(int count)
    {
        using var context = new Context();

        Random rand = new();
        int skipper = rand.Next(1, context.Products.Count());

        return context
            .Products
            .OrderBy(product => Guid.NewGuid())
            .Skip(skipper)
            .Take(count)
            .ToList();
    }

    public static List<Employees> GetManagers()
    {
        using var context = new Context();

        List<Employees> employees = context.Employees.ToList();
        
        return employees
            .Where(employee => employee.ReportsTo.HasValue)
            .ToList()
            .OrderBy(employee => employee.LastName)
            .GroupBy(employee => employee.ReportsTo)
            .ToList().Select(group => 
            employees.Find(employee => employee.EmployeeId == group.Key.Value))
            .ToList().OrderBy(x => x.LastName).ToList();
    }

    /// <summary>
    /// Little extra work than above to perform an outer sort
    /// </summary>
    [SuppressMessage("ReSharper", "All")]
    public static void EmployeeReportsToManager()
    {
        using var context = new Context();

        List<Employees> employees = context.Employees.ToList();
            
        List<IGrouping<int?, Employees>> groupedData = employees
            .Where(employee => employee.ReportsTo.HasValue)
            .ToList()
            .OrderBy(employee => employee.LastName)
            .GroupBy(employee => employee.ReportsTo)
            .ToList();

        var table = CreateViewTable();

        List<Manager> managers = new();

        foreach (var group in groupedData)
        {

            Manager manager = new()
            {
                Employee = employees.Find(employee => employee.EmployeeId == group.Key.Value)
            };

            foreach (var groupedItem in group)
            {
                manager.Workers.Add(groupedItem);
            }

            managers.Add(manager);

        }

        managers = managers.OrderBy(employee => employee.Employee.LastName).ToList();

        foreach (var manager in managers)
        {
            table.AddRow(manager.Employee.FullName);
            foreach (var worker in manager.Workers)
            {
                table.AddRow("", worker.FullName);
            }
        }

        AnsiConsole.Write(table);

    }

    private static Table CreateViewTable()
    {
        return new Table()
            .Border(TableBorder.Square)
            .BorderColor(Color.Grey100)
            .Title("~[white on blue][B]Employees[/][/]~")
            .AddColumn(new TableColumn("[u]Manager[/]"))
            .AddColumn(new TableColumn("[u]Workers[/]"));
    }

}