using Microsoft.EntityFrameworkCore;
using TesteAPI.Domain.Entities;

namespace TesteAPI.Infra
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        public DbSet<Nivel> Niveis { get; set; }
        public DbSet<Desenvolvedor> Desenvolvedores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: "DefaultConnection");
            //optionsBuilder.UseSqlServer(connectionString: "Server=localhost\\SQLEXPRESS;Database=TesteApi;User Id=sa;Password=1;");
        }

    }
}
