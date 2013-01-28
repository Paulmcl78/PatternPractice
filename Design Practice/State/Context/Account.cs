using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using State.ConcreteState;

namespace State.Context
{
    class Account
    {
        private State.State _state;
        private string _owner;

        public Account(string owner)
        {
            // New accounts are 'Silver' by default
            _owner = owner;
            _state = new SilverState(0.0, this);
        }

        // Properties
        public double Balance
        {
            get { return _state.Balance; }
        }

        public State.State State
        {
            get { return _state; }
            set { _state = value; }
        }

        public void Deposit(double amount)
        {
            _state.Deposit(amount);
            Console.WriteLine("Deposited {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}",
              State.GetType().Name);
            Console.WriteLine("");
        }

        public void Withdraw(double amount)
        {
            _state.Withdraw(amount);
            Console.WriteLine("Withdrew {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}\n",
              State.GetType().Name);
        }

        public void PayInterest()
        {
            _state.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}\n",
              State.GetType().Name);
        }
    }
}
