using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_CalculoRetangulo
{
    public class Retangulo
    {
        public int ValorBase { get; set; }
        public int ValorAltura { get; set; }

        public Retangulo()
        {
        }

        public Retangulo(int valorBase, int valorAltura)
        {
            ValorBase = valorBase;
            ValorAltura = valorAltura;
        }
        public int CacularAreaRetangulo()
        {
            int resultado = ValorBase * ValorAltura;
            return resultado;
        }
        public void ExibirDados()
        {

            int resultado = CacularAreaRetangulo();
            Console.WriteLine("O valor da área do rentagulo é: " + resultado);


        }
    }
}
