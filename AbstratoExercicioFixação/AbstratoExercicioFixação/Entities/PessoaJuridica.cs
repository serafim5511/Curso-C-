using System;
using System.Collections.Generic;
using System.Text;

namespace AbstratoExercicioFixação.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int NumFuncionario { get; set; }

        public PessoaJuridica()
        {

        }
        public PessoaJuridica(string nome, double rendaAnual, int numFuncionario) : base(nome, rendaAnual)
        {
            NumFuncionario = numFuncionario;
        }

        public override double Pess()
        {
            if (NumFuncionario > 10 )
            {
                return RendaAnual * 0.14 ;
            }
           
            else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}
