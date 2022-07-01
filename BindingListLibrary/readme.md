# About

Provides an extension method `AddRange` for the `BindingList` component.

```csharp
public static void AddRange<T>(this BindingList<T> list, IEnumerable<T> data)
{
    if (list is null || data is null)  { return; }

    try
    {
        list.RaiseListChangedEvents = false;
        foreach (T item in data)
        {
            list.Add(item);
        }
    }
    finally
    {
        list.RaiseListChangedEvents = true;
    }
}
```

Or if used in many projects consider the following [package](https://www.nuget.org/packages/BindingListLibrary/).