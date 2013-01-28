using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //create book
            Book book = new Book("Worley","Inside ASP.NET",10);
            book.Display();

            //create video
            Video video = new Video("Spielberg","Jaws",23,92);
            video.Display();

            //Make a video borrowable, then borrow and display

            Console.WriteLine("\nMaking video borrowable");

            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Joe Bloggs");
            borrowvideo.BorrowItem("Homer Simpson");

            borrowvideo.Display();

            // return a vidoe and display - notice video count
            borrowvideo.ReturnItem("Joe Bloggs");
            borrowvideo.Display();

            //wait for user
            Console.ReadKey(true);

         
        }
    }
}
