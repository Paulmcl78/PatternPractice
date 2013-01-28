using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facade.Other;
using Facade.Subsystem;

namespace Facade.Facade
{
    class Mortgage
    {
        private Bank _bank = new Bank();
        private Loan _loan = new Loan();
        private Credit _credit = new Credit();


        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine(string.Format("{0} applies for {1:C} loan\n",cust.Name,amount));

            bool eligible = true;

            if (!_bank.HasSufficientSavings(cust,amount))
            {
                eligible = false; 
            }
            else if (!_loan.HasNoBadLoans(cust))
            {
                eligible = false; 
            }
            else if (!_credit.HasGoodCredit(cust))
            {
                eligible = false; 
            }

            return eligible;
        }
    }
}
