using System;

namespace TesteServiçoPagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Contract value: ");
            double Contract = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());




            Console.WriteLine("Installments: ");


        }
    }
}
