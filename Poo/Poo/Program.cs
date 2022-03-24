using System;

namespace Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Menssagem msg1 = new Menssagem();
            msg1.TextoMensagem = "OLÁ";
            msg1.ExibirMensagem();
            Console.ReadKey();

        }
    }
}
