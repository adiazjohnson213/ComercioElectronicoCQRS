using ComercioElectronicoCQRS.Aplicacion.Commands.Clientes;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ComercioElectronicoCQRS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClientesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task RegistrarCliente(RegistrarClienteCommand registrarClienteCommand)
        {
            await _mediator.Send(registrarClienteCommand);
        }
    }
}
