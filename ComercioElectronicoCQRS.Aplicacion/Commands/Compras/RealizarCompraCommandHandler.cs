using ComercioElectronicoCQRS.Dominio.Entidades;
using ComercioElectronicoCQRS.Dominio.Servicios;
using MediatR;

namespace ComercioElectronicoCQRS.Aplicacion.Commands.Compras
{
    public class RealizarCompraCommandHandler : IRequestHandler<RealizarCompraCommand>
    {
        private readonly ICompraServicio _compraServicio;

        public RealizarCompraCommandHandler(ICompraServicio compraServicio)
        {
            _compraServicio = compraServicio;
        }

        public async Task Handle(RealizarCompraCommand request, CancellationToken cancellationToken)
        {
            await _compraServicio.RegistrarCompra(request.cedulaCliente, request.Items);
        }
    }
}
