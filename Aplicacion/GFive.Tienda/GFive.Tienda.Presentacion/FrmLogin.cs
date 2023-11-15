﻿using GFive.Tienda.Logica;
using GFive.Tienda.Modelos;
using System;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace GFive.Tienda.Presentacion
{
    public partial class FrmLogin : Form
    {
        readonly CuentaServicio servicio = new CuentaServicio();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            txtVersion.Text = "Versión: " + version;

            if (Properties.Settings.Default.Recuerdame)
            {
                txtUsuario.Text = Properties.Settings.Default.Usuario;
                txtContraseña.Text = Properties.Settings.Default.Contraseña;
                recuerdameCheckBox.Checked = Properties.Settings.Default.Recuerdame;
            }

            txtUsuario.Select();
            ActiveControl = txtUsuario;
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Usuario = recuerdameCheckBox.Checked ? txtUsuario.Text : "";
                Properties.Settings.Default.Contraseña = recuerdameCheckBox.Checked ? txtContraseña.Text : "";
                Properties.Settings.Default.Recuerdame = recuerdameCheckBox.Checked;

                Properties.Settings.Default.Save();

                DataTable resultado = servicio.IniciarSesion(txtUsuario.Text, txtContraseña.Text);
                Cuenta cuenta = new Cuenta
                {
                    IdCuenta = Convert.ToInt32(resultado.Rows[0]["ID_CUENTA"]),
                    NombreCuenta = resultado.Rows[0]["CUENTA"].ToString(),
                    Tipo = resultado.Rows[0]["TIPO_CUENTA"].ToString(),
                    Usuario = new Usuario
                    {
                        IdUsuario = Convert.ToInt32(resultado.Rows[0]["ID_USUARIO"]),
                        Nombres = resultado.Rows[0]["NOMBRES"].ToString(),
                        ApellidoPaterno = resultado.Rows[0]["APELLIDO_PATERNO"].ToString(),
                        ApellidoMaterno = resultado.Rows[0]["APELLIDO_MATERNO"].ToString(),
                        NombreCompleto = resultado.Rows[0]["NOMBRE_COMPLETO"].ToString(),
                        Dni = resultado.Rows[0]["DNI"].ToString(),
                        Sexo = resultado.Rows[0]["SEXO"].ToString(),
                        Telefono = resultado.Rows[0]["TELEFONO"].ToString()
                    }
                };
                Sesion.IniciarSesion(cuenta);

                FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal(this);
                frmMenuPrincipal.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        #region Eventos de los textboxes
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) BtnAcceder_Click(sender, e);
        }
        #endregion

        #region Eventos de los páneles de usuario  y contraseña
        private void PanelUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Select();
            ActiveControl = txtUsuario;
        }

        private void PanelUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.BackColor = panelUsuario.BackColor = Color.White;
            txtContraseña.BackColor = panelContraseña.BackColor = SystemColors.Control;
        }

        private void PanelContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.Select();
            ActiveControl = txtContraseña;
        }

        private void PanelContraseña_Enter(object sender, EventArgs e)
        {
            txtUsuario.BackColor = panelUsuario.BackColor = SystemColors.Control;
            txtContraseña.BackColor = panelContraseña.BackColor = Color.White;
        }
        #endregion

        #region Eventos del ícono de contraseña
        private void IconoContraseña_MouseUp(object sender, MouseEventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void IconoContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
        }
        #endregion

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
