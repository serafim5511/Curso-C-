using System;

namespace Exericio2._3 {
    class Program {
        static void Main(string[] args) {

            CalculoAluno aluno1 = new CalculoAluno();


            Console.Write("Nome do aluno: ");
            aluno1.nome = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno: ");

            aluno1.n1 = double.Parse(Console.ReadLine());
            aluno1.n2 = double.Parse(Console.ReadLine());
            aluno1.n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota final = "+aluno1.media().ToString("f2"));
            if (aluno1.media() >=60.00) {
                Console.WriteLine("Aprovado!");
            } else {
                Console.WriteLine("Reprovado!");
                Console.WriteLine("Faltaram "+ (60.00-aluno1.media()).ToString("f2") + " PONTOS");
            }

        }
    }
}
