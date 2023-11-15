using GFive.Tienda.Conexion;
using GFive.Tienda.Modelos;
using System.Collections.Generic;
using System.Data;

namespace GFive.Tienda.Repositorio
{
    public class UsuarioRepositorio
    {
        public DataSet GETUsuarios()
        {
            string storedProcedure = "SCHEMA_TIENDA.SP_GET_USUARIOS";

            return DBTIENDAContext.GET(storedProcedure, null);
        }

        public int SETUsuario(Usuario usuario)
        {
            string storedProcedure = "SCHEMA_TIENDA.SP_SET_USUARIO";

            List<DbParametro> dbParametros = new List<DbParametro>
            {
                new DbParametro("p_ID_USUARIO", usuario.IdUsuario),
                new DbParametro("p_NOMBRES", usuario.Nombres),
                new DbParametro("p_APELLIDO_PATERNO", usuario.ApellidoPaterno),
                new DbParametro("p_APELLIDO_MATERNO", usuario.ApellidoMaterno),
                new DbParametro("p_NOMBRE_COMPLETO", usuario.NombreCompleto),
                new DbParametro("p_DNI", usuario.Dni),
                new DbParametro("p_SEXO", usuario.Sexo),
                new DbParametro("p_TELEFONO", usuario.Telefono),
                new DbParametro("p_USUARIO_REGISTRO", usuario.UsuarioRegistro)
            };

            return DBTIENDAContext.SET(storedProcedure, dbParametros);
        }
    }

}
