# About

Language extension methods for Enum

```csharp
/// <summary>
/// Generic method to get descriptions for enum members
/// </summary>
/// <typeparam name="T">enum</typeparam>
/// <returns>list of <see cref="ItemContainer"/> </returns>
/// <remarks>If T is not an enum an exception is thrown</remarks>
public static List<ItemContainer> GetItems<T>()
{
    if (!typeof(T).IsEnum)
    {
        throw new ArgumentException("Must be an enum");
    }

    return Enum.GetValues(typeof(T)).Cast<T>()
        .Cast<Enum>()
        .Select(value => new ItemContainer
        {
            Description =
                ((GetCustomAttribute(value.GetType().GetField(value.ToString())!,
                    typeof(DescriptionAttribute)) as DescriptionAttribute)!)
                .Description,
            Value = value
        }).ToList();
}
```


