using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter.Target
{
    public class Compound
    {
        protected string _chemical;
        protected float _boilingPoint;
        protected float _meltingPoint;
        protected double _molecularWeight;
        protected string _molecularFormula;

        //constructor
        public  Compound (string chemical)
        {
            _chemical = chemical;
        }

        public virtual void Display()
        {
            Console.WriteLine(string.Format("\nCompound : {0} ----- ",_chemical));
        }
    }
}
