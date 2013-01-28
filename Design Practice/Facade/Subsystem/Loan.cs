using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facade.Other;

namespace Facade.Subsystem
{
    class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for " + c.Name);
            return true; 
        }
    }
}
