using ComercioElectronicoCQRS.Dominio.DTOs;

namespace ComercioElectronicoCQRS.Dominio.Servicios
{
    public interface ICompraServicio
    {
        Task RegistrarCompra(int cedulaCliente, IEnumerable<ItemDTO> items);

        Task<IEnumerable<HistorialDeComprasDTO>> ObtenerHistorialDeComprasPorCedula(int cedula);
    }
}