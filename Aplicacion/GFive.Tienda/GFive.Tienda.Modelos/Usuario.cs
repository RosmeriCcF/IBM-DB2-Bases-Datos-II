using System;

namespace GFive.Tienda.Modelos
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string NombreCompleto { get; set; }
        public string Dni { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public int UsuarioRegistro { get; set; }
    }
}
