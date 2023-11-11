using ComercioElectronicoCQRS.Dominio.Entidades;
using ComercioElectronicoCQRS.Dominio.Servicios;
using MediatR;

namespace ComercioElectronicoCQRS.Aplicacion.Commands.Productos
{
    public class RegistrarProductoCommandHandler : IRequestHandler<RegistrarProductoCommand>
    {
        private readonly IServicioProducto _servicioProducto;

        public RegistrarProductoCommandHandler(IServicioProducto servicioProducto)
        {
            _servicioProducto = servicioProducto;
        }
        public async Task Handle(RegistrarProductoCommand request, CancellationToken cancellationToken)
        {
            await _servicioProducto.RegistrarProducto(new Producto { Nombre = request.Nombre, Descripcion = request.Descripcion });
        }
    }
}
