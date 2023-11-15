using GFive.Tienda.Modelos;
using GFive.Tienda.Repositorio;
using System.Data;

namespace GFive.Tienda.Logica
{
    public class CategoriaServicio
    {
        private readonly CategoriaRepositorio categoriaRepositorio;

        public CategoriaServicio()
        {
            categoriaRepositorio = new CategoriaRepositorio();
        }

        public DataTable SelectAll()
        {
            return categoriaRepositorio.GETCategorias().Tables[0];
        }

        public void Update(Categoria categoria)
        {
            categoriaRepositorio.SETCategoria(categoria);
        }

        public void Insert(Categoria categoria)
        {
            categoriaRepositorio.SETCategoria(categoria);
        }
    }
}
