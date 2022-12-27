using System.Drawing;

namespace EnumComparisionApp;

internal class Program
{
    static void Main(string[] args)
    {


Console.WriteLine(
    string.Join(",", 
        Enumerable.Range(0, 10)
            .Select(_ => Random.Shared.Next(150)
            )));




        Console.ReadLine();
    }

    private static void Sample1()
    {
        Console.WriteLine(Enum.TryParse("DairyProducts", true, out Categories category)
            ? $"Found: {category}"
            : $"Could not find the specified {nameof(Categories)}");

        Console.WriteLine(Enum.TryParse("dairyproducts", true, out Categories categoryCaseInsensitive)
            ? $"Found: {categoryCaseInsensitive}"
            : $"Could not find the specified {nameof(Categories)}");

        Console.WriteLine(Enum.TryParse("dairy products", out Categories categoryNotFound)
            ? $"Found: {categoryNotFound}"
            : $"Could not find the specified {nameof(Categories)}");
    }
}
public enum Categories
{
    Beverages,
    DairyProducts,
    GrainsCereals,
    Produce
}

class Circle
{
    public Point Center { get; private set; }
    public Color Color { get; private set; }
    public int Radius { get; private set; }
    public void Draw()
    {
        // draw...
    }
}
