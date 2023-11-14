namespace ComercioElectronicoCQRS.Dominio.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }

    }
}
