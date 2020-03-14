using System;

namespace ExerciciosFaculdade.Services
{
    class Veiculo
    {
        String Cor;
        String modelo;
        double velocidadeAtual;
        double velocidadeMaxima;

        public Veiculo(string cor)
        {
            this.Cor = cor;
            
        }

        public void ligar()
        {
            Console.WriteLine("O carro está ligado");
        }

        public void acelera(double quantidade)
        {
            double velocidadeNova = velocidadeAtual + quantidade;
            velocidadeAtual = velocidadeNova;
        }


        
        int pegaMarcha()
        {
            if (velocidadeAtual < 0)
            {
                return -1;
            }
            if (velocidadeAtual >= 0 && velocidadeAtual < 40)
            {
                return 1;
            }
            if (velocidadeAtual >= 40 && velocidadeAtual < 80)
            {
                return 2;
            }
            return 3;
        }
    }
}

