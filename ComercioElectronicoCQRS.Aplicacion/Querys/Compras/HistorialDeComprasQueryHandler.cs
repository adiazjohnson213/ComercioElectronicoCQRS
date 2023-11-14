using ComercioElectronicoCQRS.Dominio.DTOs;
using ComercioElectronicoCQRS.Dominio.Servicios;
using MediatR;

namespace ComercioElectronicoCQRS.Aplicacion.Querys.Compras
{
    public class HistorialDeComprasQueryHandler : IRequestHandler<HistorialDeComprasQuery, IEnumerable<HistorialDeComprasDTO>>
    {
        private readonly ICompraServicio _compraServicio;

        public HistorialDeComprasQueryHandler(ICompraServicio compraServicio)
        {
            _compraServicio = compraServicio;
        }
        public async Task<IEnumerable<HistorialDeComprasDTO>> Handle(HistorialDeComprasQuery request, CancellationToken cancellationToken)
        {
            return await _compraServicio.ObtenerHistorialDeComprasPorCedula(request.Cedula);
        }
    }
}
