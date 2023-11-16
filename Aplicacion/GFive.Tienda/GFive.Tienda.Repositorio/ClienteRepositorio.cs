using GFive.Tienda.Conexion;
using GFive.Tienda.Modelos;
using System.Collections.Generic;
using System.Data;

namespace GFive.Tienda.Repositorio
{
    public class ClienteRepositorio
    {
        public DataSet GETClientes()
        {
            string storedProcedure = "SCHEMA_TIENDA.SP_GET_CLIENTES";

            return DBTIENDAContext.GET(storedProcedure, null);
        }

        public DataSet GETClientes(string dni)
        {
            string storedProcedure = "SCHEMA_TIENDA.SP_GET_CLIENTES";

            List<DbParametro> dbParametros = new List<DbParametro>
            {
                new DbParametro("p_DNI", dni)
            };

            return DBTIENDAContext.GET(storedProcedure, dbParametros);
        }

        public List<DbParametro> SETCliente(Cliente cliente)
        {
            string storedProcedure = "SCHEMA_TIENDA.SP_SET_CLIENTE";

            List<DbParametro> dbParametros = new List<DbParametro>
            {
                new DbParametro("p_ID_USUARIO", cliente.Usuario.IdUsuario),
                new DbParametro("p_CODIGO_CLIENTE", cliente.CodigoCliente),
                new DbParametro("p_FECHA_SUBSCRIPCION", cliente.FechaSubscripcion),
                new DbParametro("p_PUNTOS_ACUMULADOS", cliente.PuntosAcumulados),
                new DbParametro("p_FLAG_ACTIVIDAD", cliente.FlagActividad)
            };

            return DBTIENDAContext.SET(storedProcedure, dbParametros);
        }
    }
}
