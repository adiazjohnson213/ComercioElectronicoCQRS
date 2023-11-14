using ComercioElectronicoCQRS.Dominio.DTOs;
using ComercioElectronicoCQRS.Dominio.Entidades;
using ComercioElectronicoCQRS.Dominio.Repositorios;

namespace ComercioElectronicoCQRS.Dominio.Servicios
{
    public class ClienteServicio : IClienteServicio
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteServicio(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public async Task<int> ConsultarIdClientePorCedula(int cedula)
        {
            return (await _clienteRepositorio.ConsultarCliente(cedula)).Id;
        }

        public async Task RegistrarCliente(ClienteDTO clienteDTO)
        {
            await _clienteRepositorio.RegistrarCliente(new Cliente { Cedula = clienteDTO.Cedula, Nombre = clienteDTO.Nombre, Correo = clienteDTO.Correo, Direccion = clienteDTO.Direccion });
        }
    }
}
