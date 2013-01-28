using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory.Client;
using AbstractFactory.Concrete_Factory;

namespace AbstractFactory
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Create and run the African animal world
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world
            ContinentFactory amercia = new AmericaFactory();
            world = new AnimalWorld(amercia);
            world.RunFoodChain();

            //wait for user input before closing application
            Console.ReadKey(true);
        }
    }
}
