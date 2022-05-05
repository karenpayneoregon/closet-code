# About

Generic extensions for [IComparable](https://docs.microsoft.com/en-us/dotnet/api/system.icomparable?view=net-6.0)



```csharp
public static class GenericExtensions
{

    public static bool Between<T>(this T value, T lowerValue, T upperValue) 
        where T : struct, IComparable<T> 
        => Comparer<T>.Default.Compare(value, lowerValue) >= 0 && 
           Comparer<T>.Default.Compare(value, upperValue) <= 0;

    public static bool BetweenExclusive<T>(this IComparable<T> sender, T minimumValue, T maximumValue) 
        => sender.CompareTo(minimumValue) > 0 && sender.CompareTo(maximumValue) < 0;

    public static bool IsGreaterThan<T>(this T sender, T value) where T : IComparable
        => sender.CompareTo(value) > 0;

    public static bool IsLessThan<T>(this T sender, T value) where T : IComparable 
        => sender.CompareTo(value) < 0;

    public static bool IsChild(this int sender)
        => sender.Between(1, 12);

    public static bool IsOver30(this int sender) => sender.IsGreaterThan(30);
    public static string CaseWhen(this int sender)
    {
        return sender switch
        {
            { } value1 and >= 7 and <= 14 => $"I am 7 or above but less than 14: {value1}",
            { } value2 when value2.Between(4, 6) => $"I am between 4 and 6: {value2}",
            { } value3 when (value3.IsLessThan(3)) => $"I am 3 or less: {value3}",
            _ => "I'm old"
        };
    }


    /// <summary>
    /// Produces an array where the first element is startValue, last element is endValue with all values between both case insensitive.
    /// </summary>
    /// <param name="sender">List of <see cref="string"/></param>
    /// <param name="startValue">first element to start the range</param>
    /// <param name="endValue">last element to end the range</param>
    /// <returns>range between startValue and endValue or null if neither start or end values do not exist in sender array</returns>
    public static List<string> BetweenElements(this List<string> sender, string startValue, string endValue)
    {

        var startIndex = sender.FindIndex(element =>
            element.Equals(
                startValue,
                StringComparison.OrdinalIgnoreCase));

        var endIndex = sender.FindIndex(element =>
            element.Equals(
                endValue,
                StringComparison.OrdinalIgnoreCase)) - startIndex + 1;

        return startIndex == -1 || endIndex == -1 ? null : sender.GetRange(startIndex, endIndex);

    }
    /// <summary>
    /// Produces an array where the first element is startValue, last element is endValue with all values between both.
    /// </summary>
    /// <param name="sender">List of <see cref="int"/></param>
    /// <param name="startValue">first element to start the range</param>
    /// <param name="endValue">last element to end the range</param>
    /// <returns>range between startValue and endValue or null if neither start or end values do not exist in sender array</returns>
    public static List<int> BetweenElements(this List<int> sender, int startValue, int endValue)
    {

        var startIndex = sender.FindIndex(element =>
            element.Equals(startValue));

        var endIndex = sender.FindIndex(element =>
            element.Equals(endValue)) - startIndex + 1;

        return startIndex == -1 || endIndex == -1 ?
            null :
            sender.GetRange(startIndex, endIndex);
    }
}

```