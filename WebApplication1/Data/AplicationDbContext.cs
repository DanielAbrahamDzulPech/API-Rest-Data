using Domain.Modelo;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) :base(options) { }
        public DbSet<Personaje> personajes { get; set; }
        public DbSet<Genero> generos { get; set; }
    }
}
