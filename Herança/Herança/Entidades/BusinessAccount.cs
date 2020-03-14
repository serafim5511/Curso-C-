using System;
using System.Collections.Generic;
using System.Text;

namespace Herança.Entidades {
    class BusinessAccount : Account {
        public double LoanLimit { get; set; }


        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance , double loanLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {

            }
            Balance += amount;
        }

    }
}
