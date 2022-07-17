# About

Show how to get random double and random int between min and max values. For double there is truncation to two for the fraction part

```csharp
public class NumberHelpers
{

    public static double GetRandomDouble(double minimum, double maximum) 
        => Math.Truncate(100 * new Random().NextDouble() * (maximum - minimum) + minimum) / 100;

    public static int GetRandomInt(int minimum, int maximum) 
        => new Random().Next(minimum, maximum);

}
```