namespace Exercicio_AnimalEstimacao
{
    public class Animal
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }

        public Animal(string tipo, string nome)
        {
            Tipo = tipo;
            Nome = nome;
        }

        public Animal()
        {
        }

        
        //public Animal(string nome, string tipo)
        //{
        //    Nome = nome;          
        //    Tipo = tipo;
        //}
    }
}
