using InterfacesUsingAnimals.Interfaces;
using InterfacesUsingAnimals.Models;

namespace InterfacesUsingAnimals.Classes
{
    public static class Extensions
    {
        public static string MakeNoise(this IAnimal animal) => animal switch
        {
            Cat => animal.MakeNoise(),
            Dog => animal.MakeNoise(),
            Tiger => animal.MakeNoise(),
            Rabbit => animal.MakeNoise(),
            _ => ""
        };
    }
}
