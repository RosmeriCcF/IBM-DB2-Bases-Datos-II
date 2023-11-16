using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GFive.Tienda.Presentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        private readonly FrmLogin frmLogin;
        public FrmMenuPrincipal(FrmLogin frmLogin)
        {
            InitializeComponent();
            this.frmLogin = frmLogin;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ShowForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            panelContenedor.Controls.Add(form);
            form.Show();
            form.BringToFront();
        }

        private void FrmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin.Show();
        }

        private void RegistroDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmVenta());
        }

        private void registroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmUsuario());
        }

        private void registroDeCategoríasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowForm(new FrmCategoria());
        }
    }
}
