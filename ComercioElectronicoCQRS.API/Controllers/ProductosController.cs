using ComercioElectronicoCQRS.Aplicacion.Commands.Productos;
using ComercioElectronicoCQRS.Dominio.Querys.Productos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ComercioElectronicoCQRS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerProductos(ObtenerProductosQuery obtenerProductosQuery)
        {
            return Ok(await _mediator.Send(obtenerProductosQuery));
        }

        [HttpPost]
        public async Task RegistrarProducto(RegistrarProductoCommand registrarProductoCommand)
        {
            await _mediator.Send(registrarProductoCommand);
        }
    }
}
