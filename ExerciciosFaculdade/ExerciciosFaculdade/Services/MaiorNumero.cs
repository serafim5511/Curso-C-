using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosFaculdade.Services
{
    class MaiorNumero
    {
        public void Soma(int x, int y)
        {
            if (x> y)
            {
                Console.WriteLine(x +" é maior " + y);
            }
            else
                Console.WriteLine(x + " não é maior " + y);
           
        }
    }
}
