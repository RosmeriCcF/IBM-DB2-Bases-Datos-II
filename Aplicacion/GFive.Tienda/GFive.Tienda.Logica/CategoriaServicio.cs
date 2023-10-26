using GFive.Tienda.Modelos;
using GFive.Tienda.Repositorio;
using System.Data;

namespace GFive.Tienda.Logica
{
    public class CategoriaServicio
    {
        public DataTable SelectAll()
        {
            return CategoriaRepositorio.GETCategorias().Tables[0];
        }

        public void Update(Categoria categoria)
        {
            CategoriaRepositorio.SETCategoria(categoria.IdCategoria, categoria.Descripcion);
        }

        public void Insert(Categoria categoria)
        {
            CategoriaRepositorio.SETCategoria(0, categoria.Descripcion);
        }
    }
}
