using ComercioElectronicoCQRS.Dominio.Entidades;

namespace ComercioElectronicoCQRS.Dominio.Repositorios
{
    public interface IProductoRepositorio
    {
        Task<IEnumerable<Producto>> ObtenerProductos();
        Task<Producto> ObtenerProducto(int id);
        Task AgregarProducto(Producto producto);
    }
}
