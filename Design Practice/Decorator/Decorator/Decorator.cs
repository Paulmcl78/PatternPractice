using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator.Component;

namespace Decorator.Decorator
{
    abstract class Decorator : LibraryItem
    {
        protected LibraryItem LibraryItem;


        public Decorator(LibraryItem libraryItem)
        {
            LibraryItem = libraryItem;
        }

        public override void Display()
        {
            LibraryItem.Display();
        }
    }
}
