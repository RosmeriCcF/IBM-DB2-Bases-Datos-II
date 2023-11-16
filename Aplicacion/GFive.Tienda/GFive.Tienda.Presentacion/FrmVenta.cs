using GFive.Tienda.Logica;
using GFive.Tienda.Modelos;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace GFive.Tienda.Presentacion
{
    public partial class FrmVenta : Form
    {
        readonly ProductoServicio productoServicio = new ProductoServicio();
        readonly CategoriaServicio categoriaServicio = new CategoriaServicio();
        readonly ClienteServicio clienteServicio = new ClienteServicio();
        readonly VentaServicio ventaServicio = new VentaServicio();
        readonly BindingList<Producto> productosDelCarrito = new BindingList<Producto>();
        DataTable dtProducto;
        DataView dvProducto;

        public FrmVenta()
        {
            InitializeComponent();
            grdProductos.AutoGenerateColumns = false;
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            try
            {
                dtProducto = productoServicio.SelectAll();
                dvProducto = new DataView(dtProducto);
                grdProductos.DataSource = dvProducto;

                cboCategorias.DataSource = categoriaServicio.SelectAll();
                cboCategorias.DisplayMember = "DESCRIPCION";
                cboCategorias.ValueMember = "ID_CATEGORIA";
                cboCategorias.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }


        private void TxtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            dvProducto.RowFilter = $"NOMBRE LIKE '%{txtNombreProducto.Text}%'";
            grdProductos.DataSource = dvProducto;
        }

        private void ChkCategoria_CheckedChanged(object sender, EventArgs e)
        {
            cboCategorias.Enabled = chkCategoria.Checked;
        }
        private void CboCategorias_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!chkCategoria.Checked) return;

            dvProducto.RowFilter = $"ID_CATEGORIA = {cboCategorias.SelectedValue}";
            grdProductos.DataSource = dvProducto;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            chkCategoria.Checked = false;
            cboCategorias.SelectedIndex = -1;
            txtNombreProducto.Text = string.Empty;

            Buscar();
        }

        private void GrdProductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Producto producto = new Producto
            {
                IdProducto = Convert.ToInt32(grdProductos.CurrentRow.Cells[cIdProducto.Index].Value),
                Nombre = grdProductos.CurrentRow.Cells[cNombreProducto.Index].Value.ToString(),
                Descripcion = grdProductos.CurrentRow.Cells[cDescripcionProducto.Index].Value.ToString(),
                Precio = Convert.ToDecimal(grdProductos.CurrentRow.Cells[cPrecioProducto.Index].Value),
                IdCategoria = Convert.ToInt16(grdProductos.CurrentRow.Cells[cIdCategoriaProducto.Index].Value)
            };
            productosDelCarrito.Add(producto);
            grdProductos.CurrentRow.Cells[cStockProducto.Index].Value = Convert.ToInt32(grdProductos.CurrentRow.Cells[cStockProducto.Index].Value) - 1;
            CarritoDataSource.DataSource = GetCarrito();
        }

        private void GrdCarrito_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == cDisminuir.Index && e.RowIndex > -1)
            {
                Producto producto = productosDelCarrito.First(x => x.IdProducto == Convert.ToInt32(grdCarrito.CurrentRow.Cells[cIdCarrito.Index].Value));
                productosDelCarrito.Remove(producto);

                DataGridViewRow row = grdProductos.Rows.Cast<DataGridViewRow>()
                    .First(x => Convert.ToInt32(x.Cells[cIdProducto.Index].Value) == Convert.ToInt32(grdCarrito.CurrentRow.Cells[cIdCarrito.Index].Value));
                row.Cells[cStockProducto.Index].Value = Convert.ToInt32(row.Cells[cStockProducto.Index].Value) + 1;

                CarritoDataSource.DataSource = GetCarrito();
            }
        }

        private BindingList<Acumulado> GetCarrito()
        {
            txtTotalAPagar.Text = productosDelCarrito
                .Select(x => x.Precio)
                .DefaultIfEmpty()
                .Sum().ToString();

            return new BindingList<Acumulado>(productosDelCarrito
                .GroupBy(x => x.IdProducto)
                .OrderBy(x => x.First().IdProducto)
                .Select(x => new Acumulado
                {
                    IdProducto = x.First().IdProducto,
                    Nombre = x.First().Nombre,
                    Precio = x.First().Precio,
                    Stock = x.First().Stock,
                    Cantidad = x.Count(y => y.IdProducto == x.First().IdProducto),
                    SubTotal = x.Sum(y => y.Precio)
                }).ToList());
        }


        private void BtnLimpiarCarrito_Click(object sender, EventArgs e)
        {
            productosDelCarrito.Clear();
            CarritoDataSource.DataSource = GetCarrito();

            BtnLimpiar_Click(sender, e);
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            try
            {
                int idVenta = ventaServicio.RegistrarVenta(new Venta
                {
                    IdCliente = Convert.ToInt32(txtIdCliente.Text),
                    IdColaborador = Sesion.UsuarioActual.Usuario.IdUsuario,
                    MedioPago = "1",
                    Total = Convert.ToDecimal(txtTotalAPagar.Text),
                    PorcentajeIgv = Convert.ToDecimal(0.18),
                    FlagDescuento = true,
                    MontoDescuento = 0
                });

                foreach (Acumulado item in CarritoDataSource.DataSource as BindingList<Acumulado>)
                {
                    ventaServicio.RegistrarDetalleVenta(idVenta, item.IdProducto, item.Cantidad, "UNI");
                }

                MessageBox.Show("¡Se registró la venta exitosamente!", "Registro de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Buscar();
                BtnCancelar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtCliente = clienteServicio.SelectClienteByDNI(txtDniCliente.Text);
                if (dtCliente.Rows.Count > 0)
                {
                    txtIdCliente.Text = dtCliente.Rows[0]["ID_USUARIO"].ToString();
                    txtNombreCompletoCliente.Text = dtCliente.Rows[0]["NOMBRE_COMPLETO"].ToString();
                    txtPuntosAcumulados.Text = dtCliente.Rows[0]["PUNTOS_ACUMULADOS"].ToString();
                    txtFechaSubscripcion.Text = Convert.ToDateTime(dtCliente.Rows[0]["FECHA_SUBSCRIPCION"]).ToShortDateString();

                    grdProductos.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(GrdProductos_CellMouseDoubleClick);
                }
                else
                {
                    throw new Exception($"No se encontraron registros para el DNI: {txtDniCliente.Text}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtIdCliente.Text = txtNombreCompletoCliente.Text = txtPuntosAcumulados.Text = txtDniCliente.Text = txtFechaSubscripcion.Text = string.Empty;
            BtnLimpiarCarrito_Click(sender, e);

            grdProductos.CellMouseDoubleClick -= GrdProductos_CellMouseDoubleClick;
        }
    }

    public class Acumulado : Producto
    {
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
    }
}
