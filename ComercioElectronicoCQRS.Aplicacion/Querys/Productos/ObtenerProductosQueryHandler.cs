using ComercioElectronicoCQRS.Dominio.DTOs;
using ComercioElectronicoCQRS.Dominio.Servicios;
using ComercioElectronicoCQRS.Dominio.Querys.Productos;
using MediatR;

namespace ComercioElectronicoCQRS.Aplicacion.Querys.Productos
{
    public class ObtenerProductosQueryHandler : IRequestHandler<ObtenerProductosQuery, IEnumerable<ProdutoDTO>>
    {
        private readonly IServicioProducto _servicioProducto;

        public ObtenerProductosQueryHandler(IServicioProducto servicioProducto)
        {
            _servicioProducto = servicioProducto;
        }
        public async Task<IEnumerable<ProdutoDTO>> Handle(ObtenerProductosQuery request, CancellationToken cancellationToken)
        {
            return await _servicioProducto.ObtenerProductos();
        }
    }
}
