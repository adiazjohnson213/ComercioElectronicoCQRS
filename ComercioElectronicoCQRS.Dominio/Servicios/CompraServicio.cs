using ComercioElectronicoCQRS.Dominio.DTOs;
using ComercioElectronicoCQRS.Dominio.Entidades;
using ComercioElectronicoCQRS.Dominio.Repositorios;

namespace ComercioElectronicoCQRS.Dominio.Servicios
{
    public class CompraServicio : ICompraServicio
    {
        private readonly ICompraRepositorio _compraRepositorio;
        private readonly IClienteServicio _clienteServicio;
        private readonly IProductoRepositorio _productoRepositorio;

        public CompraServicio(ICompraRepositorio compraRepositorio, IClienteServicio clienteServicio, IProductoRepositorio productoRepositorio)
        {
            _compraRepositorio = compraRepositorio;
            _clienteServicio = clienteServicio;
            _productoRepositorio = productoRepositorio;
        }

        public async Task RegistrarCompra(int cedulaCliente, IEnumerable<ItemDTO> items)
        {
            var clienteId = await _clienteServicio.ConsultarIdClientePorCedula(cedulaCliente);
            var itemsEntidad = new List<Item>();
            foreach (var item in items)
            {
                var producto = await _productoRepositorio.ObtenerProducto(item.ProductoId);
                itemsEntidad.Add(new Item(item.Cantidad, item.ProductoId, producto));
            }
            await _compraRepositorio.RegistrarCompra(new Compra(clienteId, itemsEntidad));
        }

        public async Task<IEnumerable<HistorialDeComprasDTO>> ObtenerHistorialDeComprasPorCedula(int cedula)
        {
            var comprasRealizadas = await _compraRepositorio.ObtenerHistorialDeCompras(cedula);
            return comprasRealizadas.Select(c => new HistorialDeComprasDTO { 
                Cliente = new ClienteDTO { Cedula = c.Cliente.Cedula, Nombre = c.Cliente.Nombre, Correo = c.Cliente.Correo, Direccion = c.Cliente.Direccion }, 
                TotalDeCompra = c.Total,  
                Items = c.Items.Select(i => new ItemCompradoDTO { Cantidad = i.Cantidad, Produto = new ProdutoDTO { Id = i.Producto.Id, Nombre = i.Producto.Nombre, Descripcion = i.Producto.Descripcion} })});
        }
    }
}
