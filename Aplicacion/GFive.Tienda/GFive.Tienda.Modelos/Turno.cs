using System;

namespace GFive.Tienda.Modelos
{
    public class Turno
    {
        public short IdTurno { get; set; }
        public string Descripcion { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
    }
}
