using IncrementSequenceDemos.Models;

namespace IncrementSequenceDemos.Classes;

public class Operations
{
    /// <summary>
    /// Give the file holding information a name which prying eye's most likely
    /// will not look at.
    /// </summary>
    public static string FileName => 
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataLibrary.dll");


    public static void Reset()
    {
        File.Delete(FileName);
    }

    /// <summary>
    /// Create encrypted file with invoices
    /// </summary>
    public static void SerializeInvoices()
    {

        CryptoSerializer<Invoice> cryptoSerializer = new(Secrets.Key);
        using FileStream fileStream = new(FileName, FileMode.OpenOrCreate);
        cryptoSerializer.Serialize(Invoices, fileStream);
    }

    /// <summary>
    /// Used for updating/saving in <seealso cref="Save"/>
    /// </summary>
    /// <param name="list"></param>
    public static void SerializeInvoices(List<Invoice> list)
    {
        CryptoSerializer<Invoice> cryptoSerializer = new(Secrets.Key);
        using FileStream fileStream = new(FileName, FileMode.OpenOrCreate);
        cryptoSerializer.Serialize(list, fileStream);
    }

    /// <summary>
    /// Read invoices from encrypted file <seealso cref="FileName"/>
    /// </summary>
    /// <returns></returns>
    public static List<Invoice> DeserializeInvoices()
    {
        CryptoSerializer<Invoice> cryptoSerializer = new(Secrets.Key);
        using FileStream fileStream = new(FileName, FileMode.Open);
        return cryptoSerializer.Deserialize(fileStream);

    }

    /// <summary>
    /// For initial creation of the file
    /// </summary>
    public static List<Invoice> Invoices => new()
    {
        new() { Id = 1, Number = "F1124" },
        new() { Id = 2, Number = "1278-120"},
        new() { Id = 3, Number = "3999/IKL/VII/21"},
        new() { Id = 4, Number = "0001"},
        new() { Id = 5, Number = "AA0001"},
        new() { Id = 6, Number = "BB0200"},
    };

    /// <summary>
    /// Save changes back to <seealso cref="FileName"/>
    /// </summary>
    /// <param name="list"></param>
    public static void Save(List<Invoice> list)
    {
        for (int index = 0; index < list.Count; index++)
        {
            var newValue = Helpers.NextValue(list[index].Number);
            list[index].Number = newValue;
        }

        SerializeInvoices(list);
    }

    /// <summary>
    /// Create initial file
    /// </summary>
    public static void CreateReadInvoice()
    {
        SerializeInvoices();
    }
}