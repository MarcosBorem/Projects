using System;
using System.Collections.Generic;

namespace Exercicio_MaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            int max = 0;
            string nome ="";
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Informe o nome: ");
                p.Nome = Console.ReadLine();
                Console.WriteLine("Informe a idade: ");
                p.Idade = int.Parse(Console.ReadLine());
                if (p.Idade > max)
                {
                    max = p.Idade;
                    nome = p.Nome;
                }
            }
            Console.WriteLine("nome maior idade: " + nome);

            
        }
    }
}
