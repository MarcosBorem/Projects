using System;

namespace Poo_CalculoIdade
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Pessoa p = new Pessoa();
            Console.WriteLine("Informe seu Nome: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Informe seu ano de Nascimento: ");
            p.AnoNascimento = int.Parse(Console.ReadLine());
            p.ExibirDados();
            Console.ReadKey();

        }
    }
}
