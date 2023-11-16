using GFive.Tienda.Conexion;
using GFive.Tienda.Modelos;
using System.Collections.Generic;
using System.Data;

namespace GFive.Tienda.Repositorio
{
    public class CuentaRepositorio
    {
        public DataSet GETCuenta()
        {
            string storedProcedure = "SCHEMA_TIENDA.SP_GET_CUENTAS";

            return DBTIENDAContext.GET(storedProcedure, null);
        }

        public List<DbParametro> SETCuenta(Cuenta cuenta)
        {
            string storedProcedure = "SCHEMA_TIENDA.SP_SET_CUENTA";

            List<DbParametro> dbParametros = new List<DbParametro>
            {
                new DbParametro("p_ID_CUENTA", cuenta.IdCuenta),
                new DbParametro("p_ID_USUARIO", cuenta.Usuario.IdUsuario),
                new DbParametro("p_USUARIO", cuenta.Usuario),
                new DbParametro("p_CONTRASENA", cuenta.Contraseña),
                new DbParametro("p_TIPO_CUENTA", cuenta.Tipo),
                new DbParametro("p_FLAG_ACTIVIDAD", cuenta.IsActivo ? 1 : 0),
                new DbParametro("p_USUARIO_REGISTRO", cuenta.UsuarioRegistro)
            };

            return DBTIENDAContext.SET(storedProcedure, dbParametros);
        }

        public DataSet ValidarCredenciales(string usuario, string contrasena)
        {
            string storedProcedure = "SCHEMA_TIENDA.SP_VALIDAR_CREDENCIALES";

            List<DbParametro> dbParametros = new List<DbParametro>
                {
                    new DbParametro("p_USUARIO", usuario),
                    new DbParametro("p_CONTRASENA", contrasena)
                };

            return DBTIENDAContext.GET(storedProcedure, dbParametros);
        }
    }
}
