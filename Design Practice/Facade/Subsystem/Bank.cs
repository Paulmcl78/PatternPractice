using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facade.Other;

namespace Facade.Subsystem
{
    class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.Name);
            return true;
        }
    }
}
