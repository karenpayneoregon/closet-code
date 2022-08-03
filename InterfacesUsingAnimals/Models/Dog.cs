using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesUsingAnimals.Classes;
using InterfacesUsingAnimals.Interfaces;

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
