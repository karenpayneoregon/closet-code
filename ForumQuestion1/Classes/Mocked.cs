using System.Text.Json;
using ForumQuestion1.Models;

namespace ForumQuestion1.Classes;

public class Mocked
{
    private static string FileName => "data.json";

    public static void Create()
    {
        string code = "A001";
        List<DataContainer> containers = new List<DataContainer>();
        containers.Add(new DataContainer() {TrackingCode = code, CompanyName = "Apple"});
        code = Helpers.NextValue(code);
        containers.Add(new DataContainer() { TrackingCode = code, CompanyName = "Microsoft"});

        string jsonString = JsonSerializer.Serialize(containers, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(FileName, jsonString);
    }
}