using GFive.Tienda.Modelos;
using GFive.Tienda.Repositorio;
using System.Data;

namespace GFive.Tienda.Logica
{
    public class UsuarioServicio
    {
        private readonly UsuarioRepositorio usuarioRepositorio;

        public UsuarioServicio()
        {
            usuarioRepositorio = new UsuarioRepositorio();
        }

        public DataTable SelectAll()
        {
            return usuarioRepositorio.GETUsuarios().Tables[0];
        }

        public void Update(Usuario usuario)
        {
            usuarioRepositorio.SETUsuario(usuario);
        }

        public void Insert(Usuario usuario)
        {
            usuarioRepositorio.SETUsuario(usuario);
        }
    }

}
