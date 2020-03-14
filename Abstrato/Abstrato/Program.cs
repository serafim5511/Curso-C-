using System;
using Abstrato.Entities;
using Abstrato.Entities.List;
using System.Collections.Generic;

namespace Abstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> lista = new List<Shape>();
            Console.Write("Enter the namber of shape: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1 ; i <= num; i++ )
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle  or circle (r/c): ");
                char letra = char.Parse(Console.ReadLine());

                if (letra == 'r')
                {
                    Console.Write("Color (Black / Blue / Red ): ");
                    Color cor = Enum.Parse<Color>(Console.ReadLine());

                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("height: ");
                    double height = double.Parse(Console.ReadLine());

                    lista.Add(new Rectangle( width, height, cor));

                }else if(letra == 'c')
                {
                    Console.Write("Color (black / blue / red ): ");
                    Color cor = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Radius: ");
                    double raio = double.Parse(Console.ReadLine());

                    lista.Add(new Circle(cor,raio));

                }
                else { Console.WriteLine("Erro"); }

            }

            Console.WriteLine("Shape areas: ");
            foreach (Shape teste in lista)
            {
                Console.WriteLine(teste.Area());
            }


        }
    }
}
