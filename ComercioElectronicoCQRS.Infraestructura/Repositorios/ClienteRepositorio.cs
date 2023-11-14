using ComercioElectronicoCQRS.Dominio.Entidades;
using ComercioElectronicoCQRS.Dominio.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace ComercioElectronicoCQRS.Infraestructura.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly ComercioElectronicoContext _comercioElectronicoContext;

        public ClienteRepositorio(ComercioElectronicoContext comercioElectronicoContext)
        {
            _comercioElectronicoContext = comercioElectronicoContext;
        }

        public async Task<Cliente> ConsultarCliente(int cedula) => await _comercioElectronicoContext.Clientes.FirstOrDefaultAsync(c => c.Cedula == cedula);

        public async Task RegistrarCliente(Cliente cliente)
        {
            await _comercioElectronicoContext.AddAsync(cliente);
            await _comercioElectronicoContext.SaveChangesAsync();
        }
    }
}
