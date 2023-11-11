using Dominio.Querys.Productos;
using Microsoft.AspNetCore.Mvc;

namespace ComercioElectronicoCQRS.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class ComprasController : ControllerBase
    {
        public ComprasController()
        {

        }

        [HttpGet]
        public async Task<IActionResult> ObtenerProductos(ObtenerProductosQuery obtenerProductosQuery)
        {
            
        }
    }
}
