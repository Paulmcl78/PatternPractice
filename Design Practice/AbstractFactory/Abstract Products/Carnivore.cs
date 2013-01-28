using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    /// <summary>
    /// Abstract product for all Carnivore classes
    /// </summary>
    public abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }
}
