using Biblioteca.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
    }
}
