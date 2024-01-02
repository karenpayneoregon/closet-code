﻿using HasConversion.Classes;
using HasConversion.Data;
using HasConversion.Models;
using W = ConsoleHelperLibrary.Classes.WindowUtility;

// ReSharper disable once CheckNamespace
namespace HasConversion;

partial class Program
{
    /// <summary>
    /// Mock-up a <see cref="Account"/>
    /// </summary>
    static Account IncomingAccount() =>
        new()
        {
            UserName = "jackwilliams",
            Active = true,
            CreatedDate = new DateTime(1999, 7, 22),
            Email = "will@comcast.com",
            Roles = [ "User" ]
        };

    private static void ViewAccounts()
    {
        using var context = new AccountContext();
        var accountList = context.Account.ToList();

        var table = CreateViewTable();

        foreach (Account account in accountList)
        {

            if (account.Id.IsEven())
            {
                table.AddRow($"[bold yellow on green]{account.Id}[/]", $"[bold yellow on green]{account.UserName}[/]");
            }
            else
            {
                table.AddRow($"{account.Id}", account.UserName);
            }
                
            foreach (var role in account.Roles)
            {
                table.AddRow("", role.PadLeft(10));
            }

            table.AddEmptyRow();

        }

        AnsiConsole.Write(table);

        var admins = accountList.Where(account => account.Roles.Contains("Admin")).ToList();

        Console.WriteLine();

        if (admins.Count <= 0) return;
        AnsiConsole.MarkupLine("[yellow]Administrators[/]");
        foreach (var admin in admins)
        {
            AnsiConsole.MarkupLine($"[cyan]{admin.Id,-3}[/][white]{admin.UserName}[/]");
        }
        
    }
    private static void NewAccountRecord()
    {
        using var context = new AccountContext();

        var account = IncomingAccount();

        context.Add(account);
        context.SaveChanges();
        Console.WriteLine($"Id for new account {account.Id}");
    }

    private static Table CreateViewTable()
    {
        return new Table()
            .Border(TableBorder.Square)
            .BorderColor(Color.Grey100)
            .Title("[yellow][B]Accounts[/][/]")
            .AddColumn(new TableColumn("[u]Id[/]"))
            .AddColumn(new TableColumn("[u]Name and roles[/]"));
    }

    [ModuleInitializer]
    public static void Init()
    {
        Console.Title = "Code sample";
        W.SetConsoleWindowPosition(W.AnchorWindow.Center);
    }
    
}