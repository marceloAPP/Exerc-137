using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_138.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int NumeroDeFuncionarios { get; set; }

        public PessoaJuridica(int numeroDeFuncionario, string nome, double rendAnual ) 
            : base(nome, rendAnual)
        {
            NumeroDeFuncionarios = numeroDeFuncionario;
        }

        public override double Imposto()
        {
            double imp = 0;

            if (NumeroDeFuncionarios < 10)
            {
                imp += RendAnual * 0.16;
            }
            else
            {
                imp += RendAnual * 0.14;
            }

            return imp;
        }
    }
}
