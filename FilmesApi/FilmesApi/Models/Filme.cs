using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Diretor { get; set; }
        public string Genero { get; set; }
        [Range(1,600)]
        public int Duracao { get; set; }
    }
}
