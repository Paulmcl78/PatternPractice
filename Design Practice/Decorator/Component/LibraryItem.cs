﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Component
{
    abstract class LibraryItem
    {
        private int _numCopies;

        //Property 
        public int NumCopies
        {
            get { return _numCopies; }
            set { _numCopies = value; }
        }

        public abstract void Display();
    }
}
