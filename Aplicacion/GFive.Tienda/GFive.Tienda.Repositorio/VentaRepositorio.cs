using GFive.Tienda.Conexion;
using GFive.Tienda.Modelos;
using System;
using System.Collections.Generic;
using System.Data;

namespace GFive.Tienda.Repositorio
{
    public class VentaRepositorio
    {
        public int SETVenta(Venta venta)
        {
            string storedProcedure = "SCHEMA_TIENDA.SP_REGISTRAR_VENTA";
            int idVenta = 0;

            List<DbParametro> dbParametros = new List<DbParametro>
            {
                new DbParametro("p_ID_CLIENTE", venta.IdCliente),
                new DbParametro("p_ID_COLABORADOR", venta.IdColaborador),
                new DbParametro("p_MEDIO_PAGO", venta.MedioPago),
                new DbParametro("p_TOTAL", venta.Total),
                new DbParametro("p_PORCENTAJE_IGV", venta.PorcentajeIgv),
                new DbParametro("p_FLAG_DESCUENTO", venta.FlagDescuento),
                new DbParametro("p_MONTO_DESCUENTO", venta.MontoDescuento),
                new DbParametro("p_ID_VENTA", idVenta, ParameterDirection.Output)
            };

            DBTIENDAContext.SET(storedProcedure, dbParametros);

            // Obtener el valor de p_ID_VENTA después de ejecutar el SP
            idVenta = Convert.ToInt32(dbParametros.Find(p => p.Nombre == "p_ID_VENTA").Valor);

            return idVenta;
        }

        public void SETDetalleVenta(int idVenta, int idProducto, decimal cantidad, string um)
        {
            string storedProcedure = "SCHEMA_TIENDA.SP_REGISTRAR_DETALLE_VENTA";

            List<DbParametro> dbParametros = new List<DbParametro>
            {
                new DbParametro("p_ID_VENTA", idVenta),
                new DbParametro("p_ID_PRODUCTO", idProducto),
                new DbParametro("p_CANTIDAD", cantidad),
                new DbParametro("p_UM", um)
            };

            DBTIENDAContext.SET(storedProcedure, dbParametros);
        }


    }
}
