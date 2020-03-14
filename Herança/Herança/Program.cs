using System;
using Herança.Entidades;

namespace Herança {
    class Program {
        static void Main(string[] args)
        {
            BusinessAccount pessoa = new BusinessAccount(500, "gabriel", 200.00, 100.00);

            pessoa.Loan(100.00);
            Console.WriteLine(pessoa.Balance);

            Account pessoa1 = new BusinessAccount(100, "tesre", 200.00, 100.00);
        }
    }
}   
