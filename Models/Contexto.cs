using Microsoft.EntityFrameworkCore;
namespace estudo.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Mecanico> Mecanicos { get; set; }

    }
}