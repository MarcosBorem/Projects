using System;

namespace Exercicio_CalculoRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            Console.WriteLine("Informe o valor da base do retângulo: ");
            r.ValorBase = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da altura do retângulo: ");
            r.ValorAltura = int.Parse(Console.ReadLine());
            
            r.ExibirDados();
        }
    }
}
