using ComercioElectronicoCQRS.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ComercioElectronicoCQRS.Infraestructura
{
    public class ComercioElectronicoContext : DbContext
    { 
        public DbSet<Producto> Productos { get; set; }
        public ComercioElectronicoContext(DbContextOptions<ComercioElectronicoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>();
            base.OnModelCreating(modelBuilder);
        }

    }
}