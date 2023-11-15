namespace GFive.Tienda.Modelos
{
    public class Cuenta
    {
        public int IdCuenta { get; set; }
        public Usuario Usuario { get; set; }
        public string NombreCuenta { get; set; }
        public string Contraseña { get; set; }
        public string Tipo { get; set; }
        public bool IsActivo { get; set; }
        public int UsuarioRegistro { get; set; }
    }
}
