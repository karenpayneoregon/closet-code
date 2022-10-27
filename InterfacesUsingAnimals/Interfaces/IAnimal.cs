using InterfacesUsingAnimals.Classes;

namespace InterfacesUsingAnimals.Interfaces;

public interface IAnimal
{
    public string Name { get; set; }

    public Size Size { get; set; }

    public string Eats { get; set; }

    string MakeNoise();
}