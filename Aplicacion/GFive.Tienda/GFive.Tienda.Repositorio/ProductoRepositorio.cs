using GFive.Tienda.Conexion;
using GFive.Tienda.Modelos;
using System.Collections.Generic;
using System.Data;

namespace GFive.Tienda.Repositorio
{
    public class ProductoRepositorio
    {
        public DataSet GETProducto()
        {
            string storedProcedure = "SCHEMA_TIENDA.SP_GET_PRODUCTOS";
            return DBTIENDAContext.GET(storedProcedure, null);
        }

        public List<DbParametro> SETProducto(Producto producto)
        {
            string storedProcedure = "SCHEMA_TIENDA.SP_SET_PRODUCTO";

            List<DbParametro> dbParametros = new List<DbParametro>
            {
                new DbParametro("p_ID_PRODUCTO", producto.IdProducto),
                new DbParametro("p_NOMBRE", producto.Nombre),
                new DbParametro("p_DESCRIPCION", producto.Descripcion),
                new DbParametro("p_PRECIO", producto.Precio),
                new DbParametro("p_STOCK", producto.Stock),
                new DbParametro("p_ID_CATEGORIA", producto.IdCategoria),
                new DbParametro("p_ID_PROVEEDOR", producto.IdProveedor)
            };

            return DBTIENDAContext.SET(storedProcedure, dbParametros);
        }
    }

}
