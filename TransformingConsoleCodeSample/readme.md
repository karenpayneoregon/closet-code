# About

Generic transformer which at the core uses `Array.ConvertAll`.


```csharp
private static void StringToIntPersevere()
{
    Console.WriteLine(nameof(StringToIntPersevere));
    var transformer = new StringToIntTransformer();
    string[] input = Enumerable.Range(1, 10).Select(value => value.ToString()).ToArray();
    
    input[0] = "";
    input[5] = "12.4";

    var result = input.Transform(transformer);
    
    Console.WriteLine($" In: {string.Join(", ", input)}");
    Console.WriteLine($"Out: {string.Join(", ", result)}");

    Console.ReadLine();
}

```

**Results**

*StringToIntPersevere*

 In: , 2, 3, 4, 5, 12.4, 7, 8, 9, 10</br>
Out: 0, 2, 3, 4, 5, 0, 7, 8, 9, 10



```csharp
private static void SplitCamelCase()
{
    
    Console.WriteLine(nameof(SplitCamelCase));

    var transformer = new CamelCaseTransformer();
    string[] input = { "FirstName", "LastName", "JoinDate" };
    var result = input.Transform(transformer);
    Console.WriteLine($" In: {string.Join(", ", input)}");
    Console.WriteLine($"Out: {string.Join(", ", result)}");
    Console.ReadLine();
}
```

**Results**

*SplitCamelCase*

 In: FirstName, LastName, JoinDate</br>
Out: First Name, Last Name, Join Date
