using IBM.Data.DB2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GFive.Tienda.Conexion
{
    public static class DBTIENDAContext
    {

        private static string ConnectionString
        {
            get
            {
                DB2ConnectionStringBuilder stringBuilder = new DB2ConnectionStringBuilder
                {
                    Database = "DBTIENDA",
                    UserID = "admin",
                    Password = "admin",
                    Server = "localhost:25000"
                };
                return stringBuilder.ConnectionString;
            }
        }

        public static DataSet GET(string query)
        {
            return GET(query, null, CommandType.Text);
        }

        public static DataSet GET(string storedProcedure, List<DbParametro> dbParametros)
        {
            return GET(storedProcedure, dbParametros, CommandType.StoredProcedure);
        }

        public static DataSet GET(string storedProcedure, List<DbParametro> dbParametros, CommandType commandType)
        {
            DataSet dataSet = new DataSet();
            using (DB2Connection connection = new DB2Connection(ConnectionString))
            using (DB2Command command = new DB2Command(storedProcedure, connection))
            {
                try
                {
                    connection.Open();

                    command.CommandType = commandType;

                    if (command.CommandType == CommandType.StoredProcedure && dbParametros != null && dbParametros.Count > 0)
                    {
                        DB2CommandBuilder.DeriveParameters(command);
                        foreach (DB2Parameter item in command.Parameters)
                        {
                            item.Value = dbParametros.FirstOrDefault(x => x.Nombre.ToUpper().Trim().Equals(item.ParameterName))?.Valor;
                        }
                    }

                    DB2DataAdapter DataAdapter = new DB2DataAdapter(command);
                    DataAdapter.Fill(dataSet);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }

            return dataSet;
        }

        public static List<DbParametro> SET(string query)
        {
            return SET(query, null, CommandType.Text);
        }

        public static List<DbParametro> SET(string storedProcedure, List<DbParametro> dbParametros)
        {
            return SET(storedProcedure, dbParametros, CommandType.StoredProcedure);
        }

        public static List<DbParametro> SET(string storedProcedure, List<DbParametro> dbParametros, CommandType commandType)
        {
            using (DB2Connection connection = new DB2Connection(ConnectionString))
            using (DB2Command command = new DB2Command(storedProcedure, connection))
            {
                try
                {
                    connection.Open();

                    command.CommandType = commandType;

                    if (command.CommandType == CommandType.StoredProcedure && dbParametros != null && dbParametros.Count > 0)
                    {
                        DB2CommandBuilder.DeriveParameters(command);
                        foreach (DB2Parameter item in command.Parameters)
                        {
                            item.Value = dbParametros.FirstOrDefault(x => x.Nombre.ToUpper().Trim().Equals(item.ParameterName))?.Valor;
                        }
                    }

                    command.ExecuteNonQuery();

                    if (command.CommandType == CommandType.StoredProcedure && dbParametros != null && dbParametros.Count > 0)
                    {
                        foreach (DbParametro item in dbParametros)
                        {
                            item.Valor = command.Parameters[item.Nombre.ToUpper().Trim()].Value;                            
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }

            return dbParametros;
        }
    }
}