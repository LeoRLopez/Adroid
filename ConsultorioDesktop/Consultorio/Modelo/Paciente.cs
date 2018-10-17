//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Paciente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paciente()
        {
            this.Factura = new HashSet<Factura>();
            this.SegurosMedicosPaciente = new HashSet<SegurosMedicosPaciente>();
            this.Turno = new HashSet<Turno>();
        }
    
        public int IdPaciente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public long NumeroDocumento { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public bool PrimeraAtencion { get; set; }
        public string TelCelular { get; set; }
        public Nullable<int> IdHistoriaClinica { get; set; }
        public Nullable<int> IdFormaPagoPorDefecto { get; set; }
        public Nullable<int> IdSeguroMedico { get; set; }
        public string Direccion { get; set; }
        public string CodigoPostal { get; set; }
        public int IdCiudad { get; set; }
        public int IdProvincia { get; set; }
        public int IdPais { get; set; }
    
        public virtual Ciudad Ciudad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura> Factura { get; set; }
        public virtual HistoriaClinica HistoriaClinica { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual Provincia Provincia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SegurosMedicosPaciente> SegurosMedicosPaciente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turno> Turno { get; set; }
    }
}
