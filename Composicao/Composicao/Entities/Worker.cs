using System;
using System.Collections.Generic;
using Composicao.Entities.Enums;

namespace Composicao.Entities {
    class Worker {

        public string Name { get; set; }
        public WorkLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Department Department { get; set; }

        public List<HourContract> Contract { get;private set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            
        }

        public void addContract(HourContract contract)
        {
            Contract.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contract.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double som = BaseSalary;
            foreach (HourContract contract in Contract)
            {
                
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    som += contract.totalValue();
                   
                }
            }
            return som;
        }
    }
}
