using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesUsingAnimals.Classes;

namespace InterfacesUsingAnimals.Interfaces
{
    public interface IAnimal
    {
        public string Name { get; set; }

        public Size Size { get; set; }

        public string Eats { get; set; }

        string MakeNoise();
    }
}
