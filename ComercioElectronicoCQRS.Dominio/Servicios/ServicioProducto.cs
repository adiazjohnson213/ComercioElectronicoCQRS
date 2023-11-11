using ComercioElectronicoCQRS.Dominio.DTOs;
using ComercioElectronicoCQRS.Dominio.Entidades;
using ComercioElectronicoCQRS.Dominio.Repositorios;

namespace ComercioElectronicoCQRS.Dominio.Servicios
{
    public class ServicioProducto : IServicioProducto
    {
        private readonly IProductoRepositorio _productoRepositorio;

        public ServicioProducto(IProductoRepositorio productoRepositorio)
        {
            _productoRepositorio = productoRepositorio;
        }

        public async Task<IEnumerable<ProdutoDTO>> ObtenerProductos()
        {
            var productos = await _productoRepositorio.ObtenerProductos();
            return productos.Select(p => new ProdutoDTO { Nombre = p.Nombre, Descripcion = p.Descripcion });
        }

        public async Task RegistrarProducto(Producto producto)
        {
            await _productoRepositorio.AgregarProducto(producto);
        }
    }
}
