using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using State.Context;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            //open a new account
            Account account = new Account("Joe Bloggs");

            //Apply Financial transactions
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);

            //wait for user input
            Console.ReadKey(true);
        }
    }
}
