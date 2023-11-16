using GFive.Tienda.Modelos;
using GFive.Tienda.Repositorio;

namespace GFive.Tienda.Logica
{
    public class VentaServicio
    {
        private readonly VentaRepositorio ventaRepositorio;

        public VentaServicio()
        {
            ventaRepositorio = new VentaRepositorio();
        }

        public int RegistrarVenta(Venta venta)
        {
            return ventaRepositorio.SETVenta(venta);
        }

        public void RegistrarDetalleVenta(int idVenta, int idProducto, decimal cantidad, string um)
        {
            ventaRepositorio.SETDetalleVenta(idVenta, idProducto, cantidad, um);
        }
    }
}
