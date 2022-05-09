# About

Unsual decimal extensions.

```csharp
public static class Extensions
{
    /// <summary>
    /// Get fractional part of a number
    /// </summary>
    /// <param name="sender">decimal with a value</param>
    /// <returns>Fraction of <see cref="sender"/></returns>
    public static decimal GetFraction(this decimal sender) => sender % 1.0m;

    /// <summary>
    /// Get decimal places
    /// </summary>
    /// <param name="sender">decimal with a value</param>
    /// <returns>decimal places to the right</returns>
    public static decimal CountDecimalPlaces(this decimal sender)
    {

        int[] bits = decimal.GetBits(sender);
        ulong lowInt = (uint)bits[0];
        ulong midInt = (uint)bits[1];
        int exponent = (bits[3] & 0x00FF0000) >> 16;
        int result = exponent;
        ulong lowDecimal = lowInt | (midInt << 32);
        while (result > 0 && (lowDecimal % 10) == 0)
        {
            result--;
            lowDecimal /= 10;
        }

        return result;
    }
}
```