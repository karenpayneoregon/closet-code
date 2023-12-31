using InterfacesUsingAnimals.Classes;
using InterfacesUsingAnimals.Interfaces;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace InterfacesUsingAnimals.Models
{
    public class Dog : IAnimal
    {
        public string Name { get; set; }

        public Size Size { get; set; }

        public string Eats { get; set; }

        public string MakeNoise() => "Bark";
    }

    public class Cat : IAnimal
    {
        public string Name { get; set; }

        public Size Size { get; set; }

        public string Eats { get; set; }

        public string MakeNoise() => "Meow";
    }

    public class Rabbit : IAnimal
    {
        public string Name { get; set; }

        public Size Size { get; set; }

        public string Eats { get; set; }

        public string MakeNoise() => "growl";
    }

    public class Tiger : IAnimal
    {
        public string Name { get; set; }

        public Size Size { get; set; }

        public string Eats { get; set; }

        public string MakeNoise() => "Roar";
    }

}
