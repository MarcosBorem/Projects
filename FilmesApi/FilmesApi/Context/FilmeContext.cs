using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Context
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> options) : base(options)
        {

        }
        public DbSet<Filme> Filme { get; set; }
    }
}
