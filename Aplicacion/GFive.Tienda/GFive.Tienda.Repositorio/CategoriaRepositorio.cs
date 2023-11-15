using GFive.Tienda.Conexion;
using GFive.Tienda.Modelos;
using System.Collections.Generic;
using System.Data;

namespace GFive.Tienda.Repositorio
{
    public class CategoriaRepositorio
    {
        public DataSet GETCategorias()
        {
            string storedProcedure = "SCHEMA_TIENDA.SP_GET_CATEGORIAS";

            return DBTIENDAContext.GET(storedProcedure, null);
        }

        public int SETCategoria(Categoria categoria)
        {
            string storedProcedure = "SCHEMA_TIENDA.SP_SET_CATEGORIA";

            List<DbParametro> dbParametros = new List<DbParametro>
            {
                new DbParametro("p_ID_CATEGORIA", categoria.IdCategoria),
                new DbParametro("p_DESCRIPCION", categoria.Descripcion)
            };

            return DBTIENDAContext.SET(storedProcedure, dbParametros);
        }
    }
}
