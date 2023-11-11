using Microsoft.EntityFrameworkCore;

namespace Infraestructura
{
    public class ComercioElectronicoContext : DbContext
    {
        public ComercioElectronicoContext(DbContextOptions<ComercioElectronicoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}