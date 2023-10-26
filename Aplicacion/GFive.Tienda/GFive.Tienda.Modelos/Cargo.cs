namespace GFive.Tienda.Modelos
{
    public class Cargo
    {
        public short IdCargo { get; set; }
        public string Descripcion { get; set; }
        public decimal Remuneracion { get; set; }
        public short IdDepartamento { get; set; }
        public decimal FlagActividad { get; set; }
    }
}
