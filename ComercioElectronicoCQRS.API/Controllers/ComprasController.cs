using ComercioElectronicoCQRS.Aplicacion.Commands.Compras;
using ComercioElectronicoCQRS.Aplicacion.Querys.Compras;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ComercioElectronicoCQRS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComprasController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ComprasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerHistorialDeCompras(HistorialDeComprasQuery historialDeComprasQuery)
        {
            return Ok(await _mediator.Send(historialDeComprasQuery));
        }

        [HttpPost]
        public async Task RealizarCompra(RealizarCompraCommand realizarCompraCommand)
        {
            await _mediator.Send(realizarCompraCommand);
        }
    }
}
