using System;
using System.Collections.Generic;
using System.Globalization;
using Exerc_138.Entities;

namespace Exerc_138
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de contribuintes: ");
            int num = int.Parse(Console.ReadLine());

            List<Contribuinte> lista = new List<Contribuinte>();

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"\nDados do contribuinte nº {i}:");
                Console.Write("Pessoa Física ou Pessoa Jurídica(F / J) ? ");
                char ch = char.Parse(Console.ReadLine());

                if (ch == 'F')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Rendimento Anual: ");
                    double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Gastos com Saúde: ");
                    double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    lista.Add(new PessoaFisica(gastoSaude, nome, renda));
                }
                else
                {
                    Console.Write("Nome ");
                    string nome = Console.ReadLine();

                    Console.Write("Rendimento Anual: ");
                    double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Numero de funcionários: ");
                    int qtd = int.Parse(Console.ReadLine());

                    lista.Add(new PessoaJuridica(qtd, nome, renda));
                }

            }

            Console.WriteLine("\nIMPOSTOS PAGOS:");
            double soma = 0;
            foreach (var item in lista)
            {
                soma += item.Imposto();
                Console.Write("\n" + item.Nome + ": R$ " + item.Imposto().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("\n\nTOTAL DE IMPOSTOS: " + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
