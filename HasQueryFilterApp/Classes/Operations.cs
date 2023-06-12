using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ShadowProperties.Data;
using ShadowProperties.Models;

using static ConfigurationLibrary.Classes.ConfigurationHelper;

#pragma warning disable CS8619

namespace HasQueryFilterApp.Classes;

public class Operations
{
    public static void Remove(Contact1 contact1)
    {
        using ShadowContext context = new();
        context.Add(contact1).State = EntityState.Deleted;
        context.SaveChanges();
    }

    public static void Update(Contact1 contact1)
    {
        using ShadowContext context = new();
        context.Add(contact1).State = EntityState.Modified;
        context.SaveChanges();
    }

    public static async Task<List<Contact1>> Contacts()
    {
        await using ShadowContext context = new();
        return await context.Contacts1.ToListAsync();
    }

    public static async Task<(int all, int filter)> GetContact1Counts()
    {
        await using ShadowContext context = new();
        var allRecords = await context.Contacts1.ToListAsync();
        var filterRecords = await context.Contacts1.IgnoreQueryFilters().ToListAsync();

        return (allRecords.Count, filterRecords.Count);
    }

    public static async Task<(bool success, Exception exception)> ResetDeleted()
    {

        try
        {
            await using SqlConnection cn = new(ConnectionString());
            await using SqlCommand cmd = new()
            {
                CommandText = "UPDATE dbo.Contact1 SET isDeleted = 0;", 
                Connection = cn
            };

            await cn.OpenAsync();
            cmd.ExecuteNonQuery();

            return (true, null);
        }
        catch (Exception e)
        {
            return (false, e);
        }

    }
}