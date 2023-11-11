using ComercioElectronicoCQRS.Dominio.Entidades;
using ComercioElectronicoCQRS.Dominio.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace ComercioElectronicoCQRS.Infraestructura.Repositorios
{
    public class ProductosRepositorio : IProductoRepositorio
    {
        private readonly ComercioElectronicoContext _comercioElectronicoContext;

        public ProductosRepositorio(ComercioElectronicoContext comercioElectronicoContext)
        {
            _comercioElectronicoContext = comercioElectronicoContext;
        }

        public async Task<IEnumerable<Producto>> ObtenerProductos()
        {
            return await _comercioElectronicoContext.Productos.ToListAsync();
        }

        public async Task AgregarProducto(Producto producto)
        {
            await _comercioElectronicoContext.Productos.AddAsync(producto);
            await _comercioElectronicoContext.SaveChangesAsync();
        }
    }
}
