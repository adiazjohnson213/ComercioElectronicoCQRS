using ComercioElectronicoCQRS.Dominio.DTOs;
using ComercioElectronicoCQRS.Dominio.Servicios;
using MediatR;

namespace ComercioElectronicoCQRS.Aplicacion.Commands.Clientes
{
    public class RegistrarClienteCommandHandler : IRequestHandler<RegistrarClienteCommand>
    {
        private readonly IClienteServicio _clienteServicio;

        public RegistrarClienteCommandHandler(IClienteServicio clienteServicio)
        {
            _clienteServicio = clienteServicio;
        }
        public async Task Handle(RegistrarClienteCommand request, CancellationToken cancellationToken)
        {
            await _clienteServicio.RegistrarCliente(new ClienteDTO { Nombre = request.Nombre, Cedula = request.Cedula, Correo = request.Correo, Direccion = request.Direccion });
        }
    }
}
