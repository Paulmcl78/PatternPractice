using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Command.Invoker;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create user and let her compute
            User user = new User();

            //user presses calculator buttons
            user.Compute('+',100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            //undo all 4 commands
            user.Undo(4);

            //redo 3 commands
            user.Redo(3);

            //wait for user
            Console.ReadKey(true);

        }
    }
}
