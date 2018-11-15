﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Consultorio.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ClinicaEntities : DbContext
    {
        public ClinicaEntities()
            : base("name=ClinicaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Bancos> Bancos { get; set; }
        public virtual DbSet<Bancos_Tarjetas> Bancos_Tarjetas { get; set; }
        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Especialidad> Especialidad { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<FormaDePago> FormaDePago { get; set; }
        public virtual DbSet<HistoriaClinica> HistoriaClinica { get; set; }
        public virtual DbSet<Horario> Horario { get; set; }
        public virtual DbSet<InfoConsultorio> InfoConsultorio { get; set; }
        public virtual DbSet<Medico> Medico { get; set; }
        public virtual DbSet<MedicoEspecialidad> MedicoEspecialidad { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<Paciente_Tarjetas> Paciente_Tarjetas { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<PersonalInterno> PersonalInterno { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<SegurosMedico> SegurosMedico { get; set; }
        public virtual DbSet<SegurosMedicosMedico> SegurosMedicosMedico { get; set; }
        public virtual DbSet<SegurosMedicosPaciente> SegurosMedicosPaciente { get; set; }
        public virtual DbSet<Tarjetas> Tarjetas { get; set; }
        public virtual DbSet<Turno> Turno { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
