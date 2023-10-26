namespace GFive.Tienda.Modelos
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public short Stock { get; set; }
        public short IdCategoria { get; set; }
        public int IdProveedor { get; set; }
    }
}
