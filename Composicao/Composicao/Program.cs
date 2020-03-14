using System;
using Composicao.Entities;
using Composicao.Entities.Enums;

namespace Composicao {
    class Program {
        static void Main(string[] args)
        {
            Console.Write("Enter department name: ");
            string depName = Console.ReadLine();

            Console.WriteLine("Enter worker date: ");
            Console.Write("Name: ");
            string Name = Console.ReadLine();

            Console.Write("Level (Junior/MidLvel/Senior): ");
            WorkLevel level = Enum.Parse<WorkLevel>( Console.ReadLine());

            Console.Write("Base Salary: ");
            double depSalary =double.Parse( Console.ReadLine());

            Department department = new Department(depName);
            Worker worker = new Worker(Name, level, depSalary, department);


            Console.Write("How many contract to this worker? ");
            int quant = int.Parse(Console.ReadLine());

            for(int i=1; i <= quant; i++)
            {

                Console.Write("Enter "+i+"contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime Date= DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hours: ");
                double valueHRS = double.Parse(Console.ReadLine());

                Console.Write("Duration hours: ");
                int durationHRS = int.Parse(Console.ReadLine());

                HourContract HrsContract = new HourContract(Date, valueHRS, durationHRS);
                worker.addContract(HrsContract);
            }

            Console.WriteLine("");
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string income =Console.ReadLine();

            int year = int.Parse(income.Substring(0, 2));
            int month= int.Parse(income.Substring(3));


            Console.WriteLine("Name: "+worker.Name);
         
            Console.WriteLine("Department: " + worker.Department.Name);
         
            Console.WriteLine("Base Salary: " + income +": "+ worker.Income(month, year));
        }
    }
}
