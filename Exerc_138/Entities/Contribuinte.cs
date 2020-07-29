using System;
using System.Collections.Generic;

namespace Exerc_138.Entities
{
    abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double RendAnual { get; set; }

        public Contribuinte(string nome, double rendAnual)
        {
            Nome = nome;
            RendAnual = rendAnual;
        }

        public abstract double Imposto(); 
    }
}
