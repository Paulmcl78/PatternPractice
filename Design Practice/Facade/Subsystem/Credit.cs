using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facade.Other;

namespace Facade.Subsystem
{
    class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Check credit for " + c.Name);
            return true; 
        }
    }
}
