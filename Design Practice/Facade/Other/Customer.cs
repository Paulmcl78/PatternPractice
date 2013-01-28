using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.Other
{
    public class Customer
    {
        private string _name;

        //constructor
        public Customer(string name)
        {
            _name = name;
        }

        // gets the name
        public string Name
        {
            get { return _name; }
        }
    }
}
