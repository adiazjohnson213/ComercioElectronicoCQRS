namespace ComercioElectronicoCQRS.Dominio.DTOs
{
    public class CompraDTO
    {
        public string Cedula { get; set; }
        public ICollection<ItemDTO> Items { get; set; } = new List<ItemDTO>();
    }
}
