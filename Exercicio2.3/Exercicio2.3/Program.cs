using System;

namespace Exercicio2._3 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Qual é a cotação do dólar? ");
            Double Cotação = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dólares voce vai comprar? ");
            Double valor = double.Parse(Console.ReadLine());

            double result = conversao(Cotação , valor);

            Console.WriteLine("Valor a ser pago em reais? " + result);
            
        }

        static double juros = 6.0;

        static double conversao(double x , double y ){
            double total = x * y;
            return total + total *juros/100;
        }
    }
}
