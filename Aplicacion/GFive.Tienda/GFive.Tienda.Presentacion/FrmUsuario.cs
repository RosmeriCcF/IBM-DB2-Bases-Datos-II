using GFive.Tienda.Logica;
using GFive.Tienda.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GFive.Tienda.Presentacion
{
    public partial class FrmUsuario : Form
    {
        UsuarioServicio servicio = new UsuarioServicio();
        DataTable dtUsuarios;
        DataView dvUsuarios;

        public FrmUsuario()
        {
            InitializeComponent();
            grdConsulta.AutoGenerateColumns = false;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            try
            {
                dtUsuarios = servicio.SelectAll();
                dvUsuarios = new DataView(dtUsuarios);
                grdConsulta.DataSource = dvUsuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            switch (filtroComboBox.SelectedIndex)
            {
                case 0:
                    dvUsuarios.RowFilter = $"ID_USUARIO LIKE '%{txtBuscar.Text}%'";
                    break;
                case 1:
                    dvUsuarios.RowFilter = $"APELLIDO_PATERNO LIKE '%{txtBuscar.Text}%'";
                    break;
                case 2:
                    dvUsuarios.RowFilter = $"APELLIDO_MATERNO LIKE '%{txtBuscar.Text}%'";
                    break;
                case 3:
                    dvUsuarios.RowFilter = $"NOMBRE_COMPLETO LIKE '%{txtBuscar.Text}%'";
                    break;
                case 4:
                    dvUsuarios.RowFilter = $"DNI LIKE '%{txtBuscar.Text}%'";
                    break;
                case 5:
                    dvUsuarios.RowFilter = $"TELEFONO LIKE '%{txtBuscar.Text}%'";
                    break;
            }

            grdConsulta.DataSource = dvUsuarios;
        }
        private void GrdConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {

        }

    }
}
