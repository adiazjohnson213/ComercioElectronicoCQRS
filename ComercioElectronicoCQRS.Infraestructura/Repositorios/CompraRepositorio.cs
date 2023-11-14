using ComercioElectronicoCQRS.Dominio.Entidades;
using ComercioElectronicoCQRS.Dominio.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace ComercioElectronicoCQRS.Infraestructura.Repositorios
{
    public class CompraRepositorio : ICompraRepositorio
    {
        private readonly ComercioElectronicoContext _comercioElectronicoContext;

        public CompraRepositorio(ComercioElectronicoContext comercioElectronicoContext)
        {
            _comercioElectronicoContext = comercioElectronicoContext;
        }

        public async Task RegistrarCompra(Compra compra)
        {
            await _comercioElectronicoContext.AddAsync(compra);
            await _comercioElectronicoContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Compra>> ObtenerHistorialDeCompras(int cedula) => await _comercioElectronicoContext.Compras
                                                                                                                        .Where(c => c.Cliente.Cedula == cedula)
                                                                                                                        .Include(c => c.Cliente)
                                                                                                                        .Include(c => c.Items)
                                                                                                                        .ThenInclude(i => i.Producto).ToListAsync();
    }
}
