using System;
using System.Collections.Generic;
using System.Text;
using AbstratoExercicioFixação.Entities;

namespace AbstratoExercicioFixação.Entities
{
    class PessoaFisica : Pessoa
    {
        
        public double Gastos { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastos) : base (nome, rendaAnual)
        {
            Gastos = gastos;
        }

        public override double Pess()
        {
            if(RendaAnual < 20000)
            {
                return RendaAnual * 0.15 - (Gastos / 2);
            }else
            {
                return RendaAnual * 0.25 - (Gastos / 2);
            }
            
        }
        
    }
}
