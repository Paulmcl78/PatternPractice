using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator;
using Decorator.Component;

namespace Decorator.ConcreteDecorator
{
    class Borrowable : Decorator.Decorator
    {

        protected List<string> borrowers = new List<string>();

        //constructor
        public Borrowable(LibraryItem libraryItem) : base(libraryItem){}

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            LibraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            LibraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (string borrower in borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }
}
