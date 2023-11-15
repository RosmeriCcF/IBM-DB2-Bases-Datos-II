using GFive.Tienda.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GFive.Tienda.Presentacion
{
    public partial class FrmVenta : Form
    {
        readonly ProductoServicio productoServicio = new ProductoServicio();
        readonly CategoriaServicio categoriaServicio = new CategoriaServicio();
        DataTable dtProducto;
        DataView dvProducto;

        public FrmVenta()
        {
            InitializeComponent();
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
            txtIdProducto.Text = string.Empty;
            dvProducto.RowFilter = $"NOMBRE LIKE '%{txtNombreProducto.Text}%'";

            grdProductos.DataSource = dvProducto;
        }

        private void TxtIdProducto_TextChanged(object sender, EventArgs e)
        {
            txtNombreProducto.Text = string.Empty;
            dvProducto.RowFilter = $"ID_PRODUCTO LIKE '%{txtIdProducto.Text}%'";

            grdProductos.DataSource = dvProducto;
        }
        private void ChkCategoria_CheckedChanged(object sender, EventArgs e)
        {
            cboCategorias.Enabled = chkCategoria.Checked;
        }
        
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            chkCategoria.Checked = false;
            cboCategorias.SelectedIndex = -1;
            txtNombreProducto.Text = txtIdProducto.Text = "";

            Buscar();
        }

    }
}
