using ComercioElectronicoCQRS.Dominio.DTOs;

namespace ComercioElectronicoCQRS.Dominio.Servicios
{
    public interface IClienteServicio
    {
        Task<int> ConsultarIdClientePorCedula(int cedula);
        Task RegistrarCliente(ClienteDTO clienteDTO);
    }
}