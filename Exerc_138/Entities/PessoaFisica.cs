using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exerc_138.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double DespesaSaude { get; set; }

        public PessoaFisica(double despesaSaude, string nome, double rendAnual) : base(nome, rendAnual)
        {
            DespesaSaude = despesaSaude;
        }

        public override double Imposto()
        {
            double imp = 0;
            if (RendAnual < 20000)
            {
                imp += (RendAnual * 0.15) - (DespesaSaude / 2);
            }
            else
            {
                imp += (RendAnual * 0.25) - (DespesaSaude / 2);
            }

            return imp;
        }
    }
}
