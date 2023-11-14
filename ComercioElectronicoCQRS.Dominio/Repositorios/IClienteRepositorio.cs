using ComercioElectronicoCQRS.Dominio.Entidades;

namespace ComercioElectronicoCQRS.Dominio.Repositorios
{
    public interface IClienteRepositorio
    {
        Task<Cliente> ConsultarCliente(int cedula);

        Task RegistrarCliente(Cliente cliente);
    }
}
