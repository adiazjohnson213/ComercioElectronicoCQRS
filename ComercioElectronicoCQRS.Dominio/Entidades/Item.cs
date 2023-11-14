namespace ComercioElectronicoCQRS.Dominio.Entidades
{
    public class Item
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public int CompraId { get; set; }
        public Compra Compra { get; set; }

        public Item()
        {

        }

        public Item(int cantidad, int productoId, Producto producto)
        {
            Cantidad = cantidad;
            ProductoId = productoId;
            Producto = producto;
        }
    }
}
