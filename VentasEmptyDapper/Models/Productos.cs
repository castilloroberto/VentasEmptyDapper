namespace VentasEmptyDapper.Models
{
    public class Productos
    {
        public int Id { get; set; }
        public string Producto { get; set; }
        public float Precio { get; set; }
        public int Existencias { get; set; }
    }
}