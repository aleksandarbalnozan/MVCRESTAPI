using Microsoft.EntityFrameworkCore;

namespace CVPorject1.Models
{
    class ModelContext : DbContext
    {
        public DbSet<Command> Commands { get;set; }
        public DbSet<Platform> Platforms { get; set; }

        public ModelContext(DbContextOptions<ModelContext> options) : base(options)
        {
        }
    }
}