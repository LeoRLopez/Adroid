﻿using Consultorio.Reportes;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class MenuInicio : Form
    {
        private bool __sesionIniciada = false;
        private bool __esAdministrador = false;
        private int __idMedico = -1;
        private IniciarSesionEventArgs __iniciarSesionEventArgs = null;

        public MenuInicio()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void barraTitulo_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void AbrirVentanaEnPanel(object ventanaHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            Form vh = ventanaHija as Form;

            vh.TopLevel = false;
            vh.Dock = DockStyle.Fill;

            this.panelContenedor.Controls.Add(vh);
            this.panelContenedor.Tag = vh;

            vh.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AbrirVentanaEnPanel(new VentanaInicio());
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            AbrirVentanaEnPanel(new ListadoPacientes(this.__esAdministrador, this.__idMedico));
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            AbrirVentanaEnPanel(new Medico());
        }

        private void btnFormasDePago_Click(object sender, EventArgs e)
        {
            Forma_Pago frmp = new Forma_Pago();
            frmp.ShowDialog();
        }

        private void MenuInicio_Load(object sender, EventArgs e)
        {
            MostrarFormIniciarSesion();

        }

        private void MostrarFormIniciarSesion()
        {
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.SesionIniciada += InicioSesion_SesionIniciada;
            var inicioSesionReuslt = inicioSesion.ShowDialog();
            if (inicioSesionReuslt == DialogResult.Abort)
                this.Close();
        }

        private void InicioSesion_SesionIniciada(object sender, EventArgs eventArgs)
        {
            var iniciarSesionEventArgs = eventArgs as IniciarSesionEventArgs;
            if (iniciarSesionEventArgs != null)
            {
                this.__sesionIniciada = true;
                this.__iniciarSesionEventArgs = iniciarSesionEventArgs;
                if (this.__iniciarSesionEventArgs.EsAdministrador)
                {
                    this.__esAdministrador = true;
                    AbrirVentanaEnPanel(new VentanaInicio());
                }
                else if (this.__iniciarSesionEventArgs.IdMedico != null)
                {
                    this.__idMedico = (int)this.__iniciarSesionEventArgs.IdMedico;
                    btnFormasDePago.Visible = false;
                    btnNuevoPersonal.Visible = false;
                    btnMedicos.Visible = false;
                    btnHome.Visible = false;
                }
                else
                {
                    AbrirVentanaEnPanel(new VentanaInicio());
                    btnNuevoPersonal.Visible = false;
                    btnPacientes.Visible = false;
                }
            }
        }

        private void MenuInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.__sesionIniciada)
            {
                if (MessageBox.Show("¿Realmente desaea salir?", "Consultorio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnNuevoPersonal_Click(object sender, EventArgs e)
        {
            NuevoPersonal formNuevoPersonal = new NuevoPersonal();
            var formNuevoPersonalResult = formNuevoPersonal.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            var ventanaReportes = new ReporteListadoPacientes();
            ventanaReportes.ShowDialog();
        }

        private void btnReportesDeTurnos_Click(object sender, EventArgs e)
        {
            var ventanaReporteTurnos = new ReporteListadoTurnosPacientes();
            ventanaReporteTurnos.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            
        }
    }
}