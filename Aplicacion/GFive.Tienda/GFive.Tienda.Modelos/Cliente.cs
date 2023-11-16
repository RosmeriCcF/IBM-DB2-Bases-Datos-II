using System;

namespace GFive.Tienda.Modelos
{
    public class Cliente
    {
        public Usuario Usuario { get; set; }
        public int CodigoCliente { get; set; }
        public DateTime FechaSubscripcion { get; set; }
        public int PuntosAcumulados { get; set; }
        public bool FlagActividad { get; set; }
    }
}
