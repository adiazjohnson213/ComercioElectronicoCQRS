namespace ComercioElectronicoCQRS.Dominio.Entidades
{
    public class Compra
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<Item> Items { get; set; } = new List<Item>();

        public Compra()
        {

        }

        public Compra(int clienteId, ICollection<Item> items)
        {
            ClienteId = clienteId;
            Items = items;
            foreach(var item in items)
            {
                Total += item.Producto.Precio * item.Cantidad;
            }
        }

    }
}
