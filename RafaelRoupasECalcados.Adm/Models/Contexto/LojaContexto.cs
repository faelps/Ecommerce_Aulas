using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace RafaelRoupasECalcados.Adm.Models.Contexto
{
    public class LojaContexto : DbContext
    {
        private readonly IConfiguration configuration;

        public LojaContexto(IConfiguration configuration)
        {
            this.configuration = configuration;
        }


        public DbSet<Produto> Produto{ get; set; }
        public DbSet<DadosDoProduto> DadosDoProduto { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.Restrict;

            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(t => t.GetProperties()).Where(p => p.ClrType == typeof(string)))
            {
                if (property.GetMaxLength() == null)
                    property.SetColumnType("varchar(200)");
            }

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("LojaContexto"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
