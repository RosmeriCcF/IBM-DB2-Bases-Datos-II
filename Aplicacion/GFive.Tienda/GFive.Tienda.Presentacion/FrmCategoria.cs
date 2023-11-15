using GFive.Tienda.Logica;
using GFive.Tienda.Modelos;
using System;
using System.Data;
using System.Windows.Forms;

namespace GFive.Tienda.Presentacion
{
    public partial class FrmCategoria : Form
    {
        readonly CategoriaServicio servicio = new CategoriaServicio();
        DataTable dtCategorias;
        DataView dvCategorias;
        public FrmCategoria()
        {
            InitializeComponent();
            grdConsulta.AutoGenerateColumns = false;
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            try
            {
                dtCategorias = servicio.SelectAll();
                dvCategorias = new DataView(dtCategorias);
                grdConsulta.DataSource = dvCategorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            dvCategorias.RowFilter = $"DESCRIPCION LIKE '%{txtBuscar.Text}%'";
            grdConsulta.DataSource = dvCategorias;
        }

        private void GrdConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cEditar.Index)
            {
                Categoria categoria = new Categoria
                {
                    IdCategoria = Convert.ToInt32(grdConsulta.CurrentRow.Cells[cId.Name].Value),
                    Descripcion = grdConsulta.CurrentRow.Cells[cDescripcion.Name].Value.ToString()
                };
                FrmNuevaCategoria frmNuevaCategoria = new FrmNuevaCategoria(categoria);
                if (frmNuevaCategoria.ShowDialog() == DialogResult.OK)
                    Buscar();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevaCategoria frmNuevaCategoria = new FrmNuevaCategoria();
            if (frmNuevaCategoria.ShowDialog() == DialogResult.OK)
                Buscar();
        }
    }
}
