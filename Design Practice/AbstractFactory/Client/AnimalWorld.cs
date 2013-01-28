using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Client
{
    /// <summary>
    /// Client that will be invoked with the top lvl abstract factory to get the
    /// correct carivor and herbivor for the continent. 
    /// </summary>
    public class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivor;

        public AnimalWorld(ContinentFactory factory)
        {
            _carnivor = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivor.Eat(_herbivore);
        }
    }
}
