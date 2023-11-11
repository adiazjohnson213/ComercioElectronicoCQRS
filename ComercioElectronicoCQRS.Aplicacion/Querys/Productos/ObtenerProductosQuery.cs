using ComercioElectronicoCQRS.Dominio.DTOs;
using MediatR;

namespace ComercioElectronicoCQRS.Dominio.Querys.Productos
{
    public class ObtenerProductosQuery : IRequest<IEnumerable<ProdutoDTO>>
    {
    }
}
