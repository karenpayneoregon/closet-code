# About

Code to create file names incrementally.

Here four files are created then display names by their index e.g. `_n`

`Log_1.txt` `Log_2.txt` `Log_3.txt` `Log_4.txt`

```csharp
static void Main(string[] args)
{
    for (int index = 0; index < 4; index++)
    {
        File.WriteAllText(Operations.NextFileName(), "");
    }

    Directory.GetFiles(".","*.txt")
        .ToList()
        .Select(item => new {FileName = Path.GetFileName(item), Index = item.SqueezeInt() })
        .OrderBy(anonymous => anonymous.Index)
        .ToList()
        .ForEach(x => Console.WriteLine(x.FileName));

    Console.ReadLine();
}
```

