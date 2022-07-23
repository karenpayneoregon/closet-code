# About

Shows two simple ways to read lines from a file, in this case into a ListBox.

- `ReadYield` benefits are when reading a larger file
- `Read` would be for small to say what one would expect to load a ListBox with e.g. 1,000 or less lines. 

```csharp
public class FileOperations
{
    public static IEnumerable<string> ReadYield(string fileName)
    {
        var lines = File.ReadAllLines(fileName);

        foreach (var line in lines)
        {
            yield return line;
        }
    }

    public static List<string> Read(string fileName) 
        => File.ReadAllLines(fileName).ToList();
}
```