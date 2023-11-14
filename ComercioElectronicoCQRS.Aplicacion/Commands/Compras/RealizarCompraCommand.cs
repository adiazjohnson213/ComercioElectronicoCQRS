using ComercioElectronicoCQRS.Dominio.DTOs;
using MediatR;

namespace ComercioElectronicoCQRS.Aplicacion.Commands.Compras
{
    public class RealizarCompraCommand : IRequest
    {
        public int cedulaCliente { get; set; }
        public IEnumerable<ItemDTO> Items { get; set; }
    }
}
