using Domain.Modelos;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) { }
        public DbSet<Personaje> personajes { get; set; }
        public DbSet<Genero> generos { get; set; }
    }
}
