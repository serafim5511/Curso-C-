using System;
using System.Collections.Generic;
using Poo.Entities;


namespace Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Enter number of employees: ");
            int quant = int.Parse(Console.ReadLine());
            for (int i=0; i < quant ;i++)
            {
                Console.WriteLine($"Employees #{i} data:");

                Console.Write("Outsourced (y/n)? ");
                char trab = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Hours: ");
                int hrs = int.Parse(Console.ReadLine());
                Console.Write("Value per hours: ");
                double valorHrs = double.Parse(Console.ReadLine());
                if (trab == 'y' || trab == 'Y')
                {
                    Console.WriteLine("Additional charge : ");
                    double ResulHrs = double.Parse(Console.ReadLine());
                    list.Add(new OutSourceEmployee(nome, hrs, valorHrs, ResulHrs));
                }
                else
                {
                    list.Add(new Employee(nome, hrs, valorHrs));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach (Employee Emp in list)
            {
                Console.WriteLine(Emp.Name +"- $ " + Emp.Payment().ToString("F2"));
            }
             
        }
    }
}
