namespace DumpingApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Dump";
        var listOfCars = new Car().GetCars();
        var listOfCartoons = new Cartoon().GetCartoons();

        Console.WriteLine(ObjectDumper.Dump(listOfCars));
        Console.WriteLine();
        Console.WriteLine(ObjectDumper.Dump(listOfCartoons));
        Console.ReadLine();
    }
}
public class Car
{
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public string Country { get; set; }

    public List<Car> GetCars()
    {
        var cars = new List<Car>();
        cars.Add(new Car() { Manufacturer = "VW", Model = "Phaeton", Country = "Germany" });
        cars.Add(new Car() { Manufacturer = "Land Rover", Model = "Range Rover Sport", Country = "UK" });
        return cars;
    }
}

public class Cartoon
{
    public string Title { get; set; }

    public List<Cartoon> GetCartoons()
    {
        var cartoons = new List<Cartoon>();
        cartoons.Add(new Cartoon() { Title = "Family Guy" });
        cartoons.Add(new Cartoon() { Title = "Americaan Dad" });
        return cartoons;
    }
}