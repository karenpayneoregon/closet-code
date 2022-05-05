# About

Code sample to translate true/false to spoken word in various languages.

```csharp
public static string ToYesNoStringIs(this bool value, LanguageCode code) =>
    code is LanguageCode.English ? value ? "Yes" : "No" :
    code is LanguageCode.Spanish ? value ? "sí" : "No" :
    code is LanguageCode.Russian ? value ? "da" : "Net" :
    code is LanguageCode.Vietnamese ? value ? "Đúng" : "Không" :
    throw new ArgumentOutOfRangeException("Unknown language code");
```

**Example**

```csharp
foreach (LanguageCode language in Enum.GetValues<LanguageCode>())
{
    Console.WriteLine($"{language,-12}{true.ToYesNoStringIs(language),-12}{false.ToYesNoStringIs(language)}");
}
```