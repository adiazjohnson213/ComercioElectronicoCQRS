using MediatR;

namespace ComercioElectronicoCQRS.Aplicacion.Commands.Productos
{
    public class RegistrarProductoCommand : IRequest
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
    }
}
