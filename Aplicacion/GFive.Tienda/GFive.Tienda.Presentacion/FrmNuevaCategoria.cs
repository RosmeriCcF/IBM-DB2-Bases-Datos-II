using GFive.Tienda.Logica;
using GFive.Tienda.Modelos;
using System;
using System.Windows.Forms;

namespace GFive.Tienda.Presentacion
{
    public partial class FrmNuevaCategoria : Form
    {
        readonly CategoriaServicio servicio = new CategoriaServicio();
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

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) BtnNuevo_Click(sender, e);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoria is null)
                {
                    servicio.Insert(new Categoria()
                    {
                        IdCategoria = 0,
                        Descripcion = txtDescripcion.Text
                    });
                    MessageBox.Show("Se registró la categoría exitosamente.", "Registrar nueva categoría", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    categoria.Descripcion = txtDescripcion.Text;
                    servicio.Update(categoria);

                    MessageBox.Show("Se actualizó la categoría exitosamente.", "Actualizar categoría", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
