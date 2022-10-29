using System.Text.Json;
using ForumQuestion1.Models;

namespace ForumQuestion1.Classes;

internal class Operations
{
    private static string FileName => "data.json";
    public static List<DataContainer> List { get; set; }
    public static List<DataContainer> ReadFile()
    {
        List = File.Exists(FileName) ? 
            JsonSerializer.Deserialize<List<DataContainer>>(File.ReadAllText(FileName)) : 
            new List<DataContainer>();

        return List;
    }

    public static void Save()
    {
        if (List.Count <= 0) return;
        string jsonString = JsonSerializer.Serialize(List, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(FileName, jsonString);
    }

    public static void Add(DataContainer sender)
    {
        var code = List.Last().TrackingCode;
        sender.TrackingCode = Helpers.NextValue(code);
    }
}