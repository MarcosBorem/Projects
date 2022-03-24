using System;

namespace Poo_CalculoIdade
{
    public class Pessoa
    {
        //PROPIEDADES DA CLASSE
        public string Nome { get; set; }
        public int AnoNascimento { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome, int anoNascimento)
        {
            Nome = nome;
            AnoNascimento = anoNascimento;
        }

        //MÉTODOS DA CLASSE
        public void ExibirDados()
        {
            Console.WriteLine("Seu nome é: " + Nome);
            int Idade = CalcularIdade();
            Console.WriteLine("Sua idade é: " + Idade + " anos");
        }

        private int CalcularIdade()
        {
            DateTime data = DateTime.Now;
            int Ano = data.Year;
            int Idade = Ano - AnoNascimento;
            return Idade;
        }
    }
}
