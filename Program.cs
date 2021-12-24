using Design_Patterns.Abstract_Factory;
using System;

namespace Design_Patterns
{
    internal class Program
    {
        private static void Main()
        {
            AnimalFactory brazilianAnimal = new BrazilForestFactory();

            var animalWorld = new AnimalWorld(brazilianAnimal);

            animalWorld.FoodChain();

            Console.ReadKey();
        }
    }
}
