using System;
using ExercicioFixacao.Entities;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Linq;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite local do aequivo : ");
            string path = Console.ReadLine();
            Console.WriteLine("Enter value  salary: ");
            double limit = double.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();


            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string nome = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(nome, email, salary));
                }
            }
            var emails = list.Where(obj => obj.Salary > limit).OrderBy(obj => obj.Email).Select(obj => obj.Email);
            var soma = list.Where(obj => obj.Email[0] == 'm').Sum(obj => obj.Salary);


            foreach (string name in emails)
            {
                Console.WriteLine(name);
            }
          
                Console.WriteLine(soma);
           
        }

    }
}

