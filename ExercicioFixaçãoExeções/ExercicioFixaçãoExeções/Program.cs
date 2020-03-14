using System;
using ExercicioFixaçãoExeções.Entities;
using ExercicioFixaçãoExeções.Entities.Exception;

namespace ExercicioFixaçãoExeções
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Intial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdraw = double.Parse(Console.ReadLine());
                Console.Write("Enter amount for withdraw: ");
                double saque = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Account novo = new Account(number, holder, balance, withdraw);
                novo.Withdraw(saque);
                Console.Write("New balance: " + novo.Balance);
            }
            catch(DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);  
            }
        }
    }
}
