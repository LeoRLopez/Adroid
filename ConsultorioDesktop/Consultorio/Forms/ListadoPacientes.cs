﻿using Consultorio.Helpers;
using Consultorio.Modelo;
using Consultorio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class ListadoPacientes : Form
    {
        private bool __esAdministrador = false;
        private int __idMedico;

        public ListadoPacientes(bool esAdministrador, int idMedico)
        {
            InitializeComponent();
            this.__esAdministrador = esAdministrador;
            this.__idMedico = idMedico;

            btnEditarPaciente.Visible = esAdministrador;
            btnNuevoPaciente.Visible = esAdministrador;


        }

        private void btnRegistrarNuevoPaciente_Click(object sender, EventArgs e)
        {
            AgregarPaciente nuevoPaciente = new AgregarPaciente();
            nuevoPaciente.ShowDialog();
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            RefrescarDataGridViewPacientes();
        }

        private void RefrescarDataGridViewPacientes()
        {
            using (var entidades = new ClinicaEntities())
            {
                var pacientes = new List<Paciente>();
                if (__idMedico == -1)
                {
                    pacientes = entidades.Paciente.ToList();
                }
                else
                {
                    var turnosMedicos = entidades.Turno.Where(x => x.IdMedico == __idMedico).ToList().Where(x=> x.Atendido != false).ToList();
                    var idPacientes = turnosMedicos.DistinctBy(x => x.IdPaciente).Select(x => x.IdPaciente).ToList();
                    pacientes = entidades.Paciente.Where(x => idPacientes.Contains(x.IdPaciente)).ToList();
                }

                var pacientesVM = new List<PacienteVM>();
                pacientesVM.AddRange(pacientes.Select(paciente =>
                new PacienteVM
                {
                    PacienteId = paciente.IdPaciente,
                    Edad = paciente.Edad.ToString(),
                    IdHistoriasClinicas = paciente.HistoriaClinica.Select(x => x.IdHistoriaClinica).ToList(),
                    NombreCompleto = paciente.Apellidos + ", " + paciente.Nombres,
                    NroDocumento = paciente.NumeroDocumento.ToString(),
                    Telefono = paciente.TelCelular,
                    Direccion = paciente.Direccion,
                    Email = paciente.Email,
                    Sexo = paciente.Sexo,
                    GrupoSanguineo = paciente.GrupoSanguineo,
                    Donante = paciente.Donante ?? false,
                    Trasplantado = paciente.Transplantado ?? false
                }).ToList());

                pacienteVMBindingSource.DataSource = pacientesVM;
            }
        }

        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow != null)
            {
                int idPacienteSeleccionado = ((PacienteVM)dgvPacientes.CurrentRow.DataBoundItem).PacienteId;
                var formEditarPaciente = new EditarPaciente(idPacienteSeleccionado);
                formEditarPaciente.ShowDialog();
                RefrescarDataGridViewPacientes();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            var formNuevoPaciente = new AgregarPaciente();
            formNuevoPaciente.ShowDialog();
            RefrescarDataGridViewPacientes();
        }

        private void dgvPacientes_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (dgvPacientes.CurrentRow != null)
            {
                var pacienteSeleccionado = ((PacienteVM)dgvPacientes.CurrentRow.DataBoundItem);
                lblNombreApellido.Text = pacienteSeleccionado.NombreCompleto;
                lblEdadSexo.Text = pacienteSeleccionado.Edad;
                lblTelefono.Text = pacienteSeleccionado.Telefono;
                lblDireccion.Text = pacienteSeleccionado.Direccion;
                txtDiagnostico.Enabled = true;
                txtDetallesConsulta.Enabled = true;
                txtDetallesConsulta.Text = pacienteSeleccionado.AntecedentesMedicos;
                lblGrupoSanguineo.Text = "Grupo y factor sanguíneo: " + pacienteSeleccionado.GrupoSanguineo;

                if (pacienteSeleccionado.Trasplantado)
                {
                    lblTrasplantado.Text = "Es trasplantado";
                }
                else
                {
                    lblTrasplantado.Text = "No es trasplantado";
                }

                if (pacienteSeleccionado.Donante)
                {
                    lblDonante.Text = "Es donante";
                }
                else
                {
                    lblDonante.Text = "No es donante";
                }

                //CargarHistoriasClinicas(pacienteSeleccionado.PacienteId);
            }
        }

        //private void CargarHistoriasClinicas(int idHistoriaClinica)
        //{
        //    using (var entidades = new ClinicaEntities())
        //    {
        //        var historiaClinica = new List<HistoriaClinica>();
        //
        //        foreach (var x in entidades.HistoriaClinica.Where(x => x.IdPaciente == idHistoriaClinica).ToList())
        //        {
        //           historiaClinica.Add(new HistoriaClinica
        //            {
        //                IdHistoriaClinica = x.IdHistoriaClinica,
        //                FechaAtencion = x.Turno.FechaYHora,
        //                Descripcion = x.Descripcion,
        //                IdPaciente = x.IdPaciente
        //
        //            });
        //        }
        //        // Usamos DistinctBy() para No mostrar Pacientes repetidos,
        //        // sino una sola fila para el mismo paciente que pudo haber sido atentido varias veces
        //        pacienteVMBindingSource.DataSource = historiaClinica.DistinctBy(x => x.IdHistoriaClinica);
        //        pacienteVMBindingSource.ResetBindings(false);
        //    }
        //}

        private void btnCompletarConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (!ValidarCamposObligatorios())
                    return;

                using (var entidades = new ClinicaEntities())
                {
                    var pacienteSeleccionado = ((PacienteVM)dgvPacientes.CurrentRow.DataBoundItem);
                    var nuevaHistoriaClinica = new HistoriaClinica();
                    nuevaHistoriaClinica.Descripcion =" /nDetalles de la consulta: " + txtDetallesConsulta.Text + " /nDiagnostico: " + txtDiagnostico.Text;
                    nuevaHistoriaClinica.FechaAtencion = DateTime.Today;
                    nuevaHistoriaClinica.IdPaciente = pacienteSeleccionado.PacienteId;
                    nuevaHistoriaClinica.IdTurno = pacienteSeleccionado.TurnoId;

                    entidades.HistoriaClinica.Add(nuevaHistoriaClinica);
                    
                    entidades.SaveChanges();
                    MessageBox.Show("Datos Editados con Éxito", "TurnARG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCamposObligatorios()
        {
            if (string.IsNullOrEmpty(txtDetallesConsulta.Text) || string.IsNullOrEmpty(txtDiagnostico.Text))
            {
                if (string.IsNullOrEmpty(txtDetallesConsulta.Text))
                    errorProvider1.SetError(txtDetallesConsulta, "Requerido");

                if (string.IsNullOrEmpty(txtDiagnostico.Text))
                    errorProvider1.SetError(txtDiagnostico, "Requerido");

                return false;
            }
            return true;
        }

    }
}