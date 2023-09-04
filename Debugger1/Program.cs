using Debugger1.Data;
using Microsoft.EntityFrameworkCore;
#pragma warning disable CS0219 // Variable is assigned but its value is never used

namespace Debugger1;

internal partial class Program
{
    static async Task Main(string[] args)
    {
        await StaticForStatement();
    }

    private static async Task FileExample()
    {
        var lines = await File.ReadAllLinesAsync("Products.txt");

        for (int index = 0; index < lines.Length; index++)
        {
            
        }
    }


    private static async Task StaticForStatement()
    {
        int counter = 0; // for break point
        await using var context =  new Context();
        var customersList = await context
            .Customers
            .Include(c => c.ContactTypeIdentifierNavigation)
            .Include(c => c.CountryIdentifierNavigation)
            .ToListAsync();

        foreach (var customers in customersList)
        {
            
        }
    }
}




