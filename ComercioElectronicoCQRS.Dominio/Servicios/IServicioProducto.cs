using ComercioElectronicoCQRS.Dominio.DTOs;
using ComercioElectronicoCQRS.Dominio.Entidades;

namespace ComercioElectronicoCQRS.Dominio.Servicios
{
    public interface IServicioProducto
    {
        Task<IEnumerable<ProdutoDTO>> ObtenerProductos();
        Task RegistrarProducto(Producto producto);
    }
}