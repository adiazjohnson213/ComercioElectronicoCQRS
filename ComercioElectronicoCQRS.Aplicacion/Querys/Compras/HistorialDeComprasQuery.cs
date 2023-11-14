using ComercioElectronicoCQRS.Dominio.DTOs;
using MediatR;

namespace ComercioElectronicoCQRS.Aplicacion.Querys.Compras
{
    public class HistorialDeComprasQuery :IRequest<IEnumerable<HistorialDeComprasDTO>>
    {
        public int Cedula { get; set; }
    }
}
