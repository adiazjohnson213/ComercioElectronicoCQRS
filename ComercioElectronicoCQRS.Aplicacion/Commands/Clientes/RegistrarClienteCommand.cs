using MediatR;

namespace ComercioElectronicoCQRS.Aplicacion.Commands.Clientes
{
    public class RegistrarClienteCommand : IRequest
    {
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
    }
}
