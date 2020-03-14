using System;
using ServiçoPagamento.Entities;
using ServiçoPagamento.Services;

namespace ServiçoPagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data ");
            Console.Write("Number ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy) ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Contract value ");
            double contract = double.Parse(Console.ReadLine());

            Console.Write("Enter number of installments ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract1 = new Contract(number, date, contract);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.processContract(contract1, installments);

            Console.WriteLine("Installments:");
            foreach (Installment installment in contract1.Installments)
            {
                Console.WriteLine(installment);


            }
        }
    }
}
