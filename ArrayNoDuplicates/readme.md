# About

:small_blue_diamond: Many coders ask how to remove duplicates, why not prevent them in the first place?

```csharp
class Program
{
    static readonly HashSet<int> _hashSet = new ();
    static void Main(string[] args)
    {
        int[] randomValues = { 1, 1, 2, 3, 4, 5, 6, 6 };

        foreach (var value in randomValues)
        {
            _hashSet.Add(value);
        }

        int[] values = _hashSet.ToArray();
        Console.WriteLine(string.Join(",", values));

        Console.ReadLine();
    }

}
```

VB for forum question

```vbnet
Private ReadOnly _hashSet As New HashSet(Of Integer)()

Sub Main(args As String())

    Dim randomValues() As Integer = { 1, 1, 2, 3, 4, 5, 6, 6 }

    For Each value In randomValues
        _hashSet.Add(value)
    Next

    Dim values() As Integer = _hashSet.ToArray()
    Console.WriteLine(String.Join(",", values))

    Console.ReadLine()

End Sub
```