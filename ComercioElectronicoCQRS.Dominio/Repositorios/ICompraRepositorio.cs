using ComercioElectronicoCQRS.Dominio.Entidades;

namespace ComercioElectronicoCQRS.Dominio.Repositorios
{
    public interface ICompraRepositorio
    {
        Task RegistrarCompra(Compra compra);
        Task<IEnumerable<Compra>> ObtenerHistorialDeCompras(int cedula);
    }
}
