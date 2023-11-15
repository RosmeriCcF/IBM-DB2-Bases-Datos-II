using GFive.Tienda.Modelos;

namespace GFive.Tienda.Presentacion
{
    public static class Sesion
    {
        public static Cuenta UsuarioActual { get; set; }

        public static void IniciarSesion(Cuenta usuario)
        {
            UsuarioActual = usuario;
        }

        public static void CerrarSesion()
        {
            UsuarioActual = null;
        }

        public static bool SesionActiva => UsuarioActual != null;
    }

}
