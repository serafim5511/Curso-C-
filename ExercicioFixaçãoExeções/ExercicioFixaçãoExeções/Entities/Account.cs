using System;
using System.Collections.Generic;
using System.Text;
using ExercicioFixaçãoExeções.Entities.Exception;

namespace ExercicioFixaçãoExeções.Entities
{
    class Account
    {
        public int Number { get; set; }

        public string Holder { get; set; }

        public double Balance{ get; set; }

        public double  WithDrawLimit{ get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void deposit(double amount)
        {
           
            
            Balance = Balance - amount;
        }

        public void Withdraw (double amount)
        {
            if (amount > Balance)
            {
                throw new DomainException("ta erarado ");
            }
            if (amount > WithDrawLimit)
            {
                throw new DomainException("ta erarado3 ");
            }
            Balance = Balance - amount;
        }
    }
}
