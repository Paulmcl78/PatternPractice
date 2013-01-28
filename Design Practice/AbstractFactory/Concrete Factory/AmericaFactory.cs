using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory.Products;

namespace AbstractFactory.Concrete_Factory
{
    /// <summary>
    /// Implemtation of a continentFactory that will be specific for America
    /// </summary>
    public class AmericaFactory: ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}
