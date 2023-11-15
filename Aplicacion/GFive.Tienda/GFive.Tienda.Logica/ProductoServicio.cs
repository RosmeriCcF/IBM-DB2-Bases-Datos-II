using GFive.Tienda.Modelos;
using GFive.Tienda.Repositorio;
using System.Data;

namespace GFive.Tienda.Logica
{
    public class ProductoServicio
    {
        private readonly ProductoRepositorio productoRepositorio;

        public ProductoServicio()
        {
            productoRepositorio = new ProductoRepositorio();
        }

        public DataTable SelectAll()
        {
            return productoRepositorio.GETProducto().Tables[0];
        }

        public void Update(Producto producto)
        {
            productoRepositorio.SETProducto(producto);
        }

        public void Insert(Producto producto)
        {
            productoRepositorio.SETProducto(producto);
        }
    }
}
