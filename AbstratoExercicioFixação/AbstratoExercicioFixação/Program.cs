using System;
using AbstratoExercicioFixação.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace AbstratoExercicioFixação
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> lista = new List<Pessoa>();

            Console.Write("Enter the number of tax payers: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Tax payer#{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char letra = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string Nome = Console.ReadLine();
                Console.Write("Anual income: ");
                double renda = double.Parse(Console.ReadLine());
                if (letra =='i')
                {                    
                    Console.Write("Health expennditures: ");
                    double saude = double.Parse(Console.ReadLine());
                    lista.Add(new PessoaFisica(Nome, renda, saude));
                }else if(letra == 'c')
                {
                    Console.Write("Number of employees: ");
                    int func = int.Parse(Console.ReadLine());
                    lista.Add(new PessoaJuridica(Nome, renda, func));
                }     
            }
            double sum = 0.0;
            Console.WriteLine("TAXES PAID: ");
            foreach (Pessoa list in lista)
            {
                double tax = list.Pess();
                Console.WriteLine(list.Nome + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }
            Console.WriteLine(sum.ToString());
        }
    }
}
