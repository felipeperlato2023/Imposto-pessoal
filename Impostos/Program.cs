using Impostos.Classes;
using System.Collections.Generic;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    public static void Main(string[] args)
    {
        List<Pessoa> lista = new List<Pessoa>();
        Console.Write("Entre com a quantidade de pessoas: ");
        int qtd = int.Parse(Console.ReadLine());



        for (int i = 1; i <= qtd; i++)
        {
            Console.Write("Pessoa (" + i + ") Fisica ou Juridica ? (f/j) ");
            char op = char.Parse(Console.ReadLine());

            if (op == 'f')
            {

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Renda Anual: ");
                double renda = double.Parse(Console.ReadLine());


                Console.Write("R$ SAÚDE: ");
                double gastosaude = double.Parse(Console.ReadLine());

                lista.Add(new Física(nome, renda, gastosaude));
            }

            if (op == 'j')
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Renda Anual: ");
                double renda = double.Parse(Console.ReadLine());

                Console.Write("Entre com a quantidade de funcionarios: ");
                int nfuncionario = int.Parse(Console.ReadLine());

                lista.Add(new Jurídica(nome, renda, nfuncionario));
            }
        }


        Console.WriteLine("RENDAS:");
        double soma = 0;

        foreach (Pessoa nomes in lista)
        {
            double taxa = nomes.Imposto();
            Console.WriteLine( nomes.Nome + " $ " + nomes.Imposto());

            soma += taxa;
        }


        Console.WriteLine("");
        Console.WriteLine("TOTAL " + soma);
    }
}

