using GFive.Tienda.Logica;
using GFive.Tienda.Modelos;
using System;
using System.Windows.Forms;

namespace GFive.Tienda.Presentacion
{
    public partial class FrmNuevoUsuario : Form
    {
        readonly UsuarioServicio servicio = new UsuarioServicio();
        private readonly Usuario usuario;

        public FrmNuevoUsuario()
        {
            InitializeComponent();
        }

        public FrmNuevoUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            lblTitulo.Text = "ACTUALIZAR USUARIO";
            //Util.Centrar(this, lblTitulo);

            txtNombres.Text = usuario.Nombres;
            txtApellidoPaterno.Text = usuario.ApellidoMaterno;
            txtApellidoMaterno.Text = usuario.ApellidoPaterno;
            txtTelefono.Text = usuario.Telefono;
            txtDni.Text = usuario.Dni;
            rdoMasculino.Checked = usuario.Sexo == "M";
            rdoFemenino.Checked = usuario.Sexo == "F";
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) BtnNuevo_Click(sender, e);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (usuario is null)
                {
                    servicio.Insert(new Usuario()
                    {
                        IdUsuario = 0,
                        Nombres = txtNombres.Text,
                        ApellidoPaterno = txtApellidoPaterno.Text,
                        ApellidoMaterno = txtApellidoMaterno.Text,
                        Dni = txtDni.Text,
                        Telefono = txtTelefono.Text,
                        Sexo = rdoMasculino.Checked ? "M" : "F",
                        //FALTA USUARIO REGISTRO
                    });
                    MessageBox.Show("Se registró el usuario exitosamente.", "Registrar nuevo usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    usuario.Nombres = txtNombres.Text;
                    usuario.ApellidoPaterno = txtApellidoPaterno.Text;
                    usuario.ApellidoMaterno = txtApellidoMaterno.Text;
                    usuario.Dni = txtDni.Text;
                    usuario.Telefono = txtTelefono.Text;
                    usuario.Sexo = rdoMasculino.Checked ? "M" : "F";
                    servicio.Update(usuario);

                    MessageBox.Show("Se actualizó el usuario exitosamente.", "Actualizar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
