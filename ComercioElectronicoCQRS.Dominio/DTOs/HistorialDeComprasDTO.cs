namespace ComercioElectronicoCQRS.Dominio.DTOs
{
    public class HistorialDeComprasDTO
    {
        public double TotalDeCompra { get; set; }
        public ClienteDTO Cliente { get; set; }
        public IEnumerable<ItemCompradoDTO> Items { get; set; }
    }
}
