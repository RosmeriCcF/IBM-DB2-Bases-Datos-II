using GFive.Tienda.Modelos;
using GFive.Tienda.Repositorio;
using System.Data;

namespace GFive.Tienda.Logica
{
    public class CuentaServicio
    {
        private readonly CuentaRepositorio cuentaRepositorio;

        public CuentaServicio()
        {
            cuentaRepositorio = new CuentaRepositorio();
        }

        public DataTable SelectAll()
        {
            return cuentaRepositorio.GETCuenta().Tables[0];
        }

        public void Update(Cuenta cuenta)
        {
            cuentaRepositorio.SETCuenta(cuenta);
        }

        public void Insert(Cuenta cuenta)
        {
            cuentaRepositorio.SETCuenta(cuenta);
        }

        public DataTable IniciarSesion(string usuario, string contrasena)
        {
            return cuentaRepositorio.ValidarCredenciales(usuario, contrasena).Tables[0];
        }
    }
}
