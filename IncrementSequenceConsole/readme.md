# About

Over the years the question 

*How do I increment an alpha-numeric value?*

Presented here may not cover all cases.

| Given        |   Expect    |
|:------------- |:-------------|
| F1124 | F1125 |  
| 1278-120 | 1278-121 |  
| 999/IKL/VII/21 | 999/IKL/VII/22 |  

Code behind

```csharp
public class Helpers
{
    public static string NextValue(string sender)
    {
        string value = Regex.Match(sender, "[0-9]+$").Value;
        return sender[..^value.Length] + (long.Parse(value) + 1)
            .ToString().PadLeft(value.Length, '0');
    }
}
```

# Requires

.NET Core 5+, C# 9 or higher