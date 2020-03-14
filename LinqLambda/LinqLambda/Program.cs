using System;
using System.Linq;
using LinqLambda.Entitites;
using System.Collections.Generic;

namespace LinqLambda
{
    class Program
    {
        static void Print<t>(string message, IEnumerable<t> collection)
        {
            Console.WriteLine(message);
            foreach(t obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computes", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product(){Id = 1 , Name = "Computer", Price = 1100.0, Category = c2},
                new Product() { Id = 1, Name = "TV", Price = 500, Category = c3 },
                new Product() { Id = 1, Name = "CELULAR", Price = 1100.0, Category = c3 }
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
              Print("Tier 1 and price < 900 ", r1);

            var r2 = products.Where(p => p.Category.Name == "Electronics").Select(p => p.Name);
            Print("NAMES of products from tools ", r2);
        }
    }
}
