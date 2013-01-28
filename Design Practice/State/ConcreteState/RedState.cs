﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State.ConcreteState
{
    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Red indicates that account is overdrawn
    /// </remarks>
    /// </summary>
    class RedState : State.State
    {
        private double _serviceFee;

        //Constructor
        public RedState(State.State state)
        {
            balance = state.Balance;
            account = state.Account;
            Initialize();
        }

        private void Initialize()
        {
            // Should come from a datasource
            interest = 0.0;
            lowerLimit = -100.0;
            upperLimit = 0.0;
            _serviceFee = 15.00;
        }

        #region Overrides of State

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            amount = amount - _serviceFee;
            Console.WriteLine("No funds available for withdrawal!");
        }

        public override void PayInterest()
        {
            // No interest is paid
        }

        private void StateChangeCheck()
        {
            if (balance > upperLimit)
            {
                account.State = new SilverState(this);
            }
        }

        #endregion
    }
}
