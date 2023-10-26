using System.Data;

namespace GFive.Tienda.Conexion
{
    public class DbParametro
    {
        public string Nombre { get; set; }
        public object Valor { get; set; }
        public ParameterDirection Direccion { get; set; }

        public DbParametro(string Nombre, object Valor)
        {
            this.Nombre = Nombre;
            this.Valor = Valor;
            this.Direccion = ParameterDirection.Input;
        }

        public DbParametro(string Nombre, object Valor, ParameterDirection Direccion)
        {
            this.Nombre = Nombre;
            this.Valor = Valor;
            this.Direccion = Direccion;
        }
    }
}
