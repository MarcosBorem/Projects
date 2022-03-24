using System;

namespace Exercicio_AnimalEstimacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            
           
            int contcachorro = 0,contgato = 0, contpeixe = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Informe o nome do animal: ");
                animal.Nome = Console.ReadLine();
                Console.WriteLine("Informe o tipo do animal: ");
                animal.Tipo = Console.ReadLine();
                if (animal.Tipo == "Cachorro")
                {
                    contcachorro++;
                }
                else if (animal.Tipo == "Gato")
                {
                    contgato++;
                }
                else
                {
                    contpeixe++;
                }
            }            
            Console.WriteLine("O total de Cachorros é: " +contcachorro);
            Console.WriteLine("O total de gatos é: " + contgato);
            Console.WriteLine("O total de peixes é: " + contpeixe);
        }
    }
}
