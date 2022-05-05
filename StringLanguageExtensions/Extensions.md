| Extension  | Description
| :--- | :--- |
| IsNullOrWhiteSpace |String to test if `null` or `whitespace` |
|UpTo|Get file name only, avoid multiple file extensions e.g. DirectoryGetFilesMultipleFilters.deps.json|
|EqualsIgnoreCase|Determines whether two specified String objects have the same value, case insensitive.|
|ContainsAny|Determines whether one or more tokens exists in a string, case insensitive.|
|RemoveAllWhiteSpace|Remove all white space in a string, at start, end and in-between|
|StringBetweenQuotes|Extract text between single quotes|
|SplitCamelCase|Split string by upper cased chars e.g. KarenAnnePayne becomes Karen Anne Payne|
|ReverseEx|Reverse characters in a string|
|ReplaceInsensitive|Replace string case insensitive|
|HasDuplications|Determine if a string has duplicate values case sensitive|
|JSonToList|Convert a json string to a list of `T`|
|IsNumeric|Determine if a string can be represented as a numeric.|
|JoinWithLastSeparator|Join string array with `" and "` as the last delimiter|
|AlphaToInteger|Get numbers from string|
|IsValidTimeFormat|Indicates if a string can represent a TimeSpan|
|SafeDateTime|Get nullable DateTime as `null` or as a `Date` |
|Indexed|Provides strong type return for use in a Lambda statement to split a string into chars along with their respected indices.|
|TrimLastCharacter|Trim last character from a string while the stock <see cref="string.TrimEnd()"/> will trim multiples e.g. given Hello!! will return Hello while this extension given Hello!! will return Hello!|
|SecondIndexOf| Get the second occurance of a period|