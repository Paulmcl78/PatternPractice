using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Products
{
    public class Wolf: Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(string.Format("{0} eats {1}",this.GetType().Name,h.GetType().Name));
        }
    }
}
