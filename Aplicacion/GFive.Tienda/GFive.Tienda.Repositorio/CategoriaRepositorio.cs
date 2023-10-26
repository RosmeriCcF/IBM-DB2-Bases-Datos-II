using GFive.Tienda.Conexion;
using System.Collections.Generic;
using System.Data;

namespace GFive.Tienda.Repositorio
{
    public class CategoriaRepositorio
    {
        public static DataSet GETCategorias()
        {
            string storedProcedure = "SCHEMA_TIENDA.SP_GET_CATEGORIAS";

            return DBTIENDAContext.GET(storedProcedure, null);
        }

        public static int SETCategoria(int idCategoria, string descripcion)
        {
            string storedProcedure = "SCHEMA_TIENDA.SP_SET_CATEGORIA";

            List<DbParametro> dbParametros = new List<DbParametro>
            {
                new DbParametro("p_ID_CATEGORIA", idCategoria),
                new DbParametro("p_DESCRIPCION", descripcion)
            };

            return DBTIENDAContext.SET(storedProcedure, dbParametros);
        }
    }
}
