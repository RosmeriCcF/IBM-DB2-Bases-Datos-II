using GFive.Tienda.Logica;
using GFive.Tienda.Modelos;
using System;
using System.Windows.Forms;

namespace GFive.Tienda.Presentacion
{
    public partial class FrmNuevaCategoria : Form
    {
        CategoriaServicio servicio = new CategoriaServicio();
        private readonly Categoria categoria;

        public FrmNuevaCategoria()
        {
            InitializeComponent();
        }

        public FrmNuevaCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;

            lblTitulo.Text = "ACTUALIZAR CATEGORÍA";
            //Util.Centrar(this, lblTitulo);

            txtDescripcion.Text = categoria.Descripcion;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) btnNuevo_Click(sender, e);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoria is null)
                {
                    servicio.Insert(new Categoria()
                    {
                        Descripcion = txtDescripcion.Text
                    });
                    MessageBox.Show("Se registró la categoría exitosamente.", "Registrar nueva categoría", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    categoria.Descripcion = txtDescripcion.Text;
                    servicio.Update(categoria);

                    MessageBox.Show("Se actualizó la categoría exitosamente.", "Actualizar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
