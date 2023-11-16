using System;

namespace GFive.Tienda.Modelos
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        public int IdColaborador { get; set; }
        public string MedioPago { get; set; }
        public decimal Subtotal { get; set; }
        public bool FlagDescuento { get; set; }
        public decimal MontoDescuento { get; set; }
        public decimal MontoIgv { get; set; }
        public decimal PorcentajeIgv { get; set; }
        public decimal Total { get; set; }
    }
}
