using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory.Products;

namespace AbstractFactory.Concrete_Factory
{
    /// <summary>
    /// Implemtation of a continentFactory that will be specific for Africa
    /// </summary>
    public class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildbeast();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
