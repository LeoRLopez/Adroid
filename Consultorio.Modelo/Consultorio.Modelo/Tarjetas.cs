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
    
    public partial class Tarjetas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tarjetas()
        {
            this.Bancos_Tarjetas = new HashSet<Bancos_Tarjetas>();
            this.Factura = new HashSet<Factura>();
            this.Paciente_Tarjetas = new HashSet<Paciente_Tarjetas>();
        }
    
        public int IdTarjeta { get; set; }
        public string Nombre { get; set; }
        public string Titular { get; set; }
        public string NumeroTarjeta { get; set; }
        public System.DateTime FechaVto { get; set; }
        public int IdBanco { get; set; }
        public bool BajaLogica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bancos_Tarjetas> Bancos_Tarjetas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura> Factura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paciente_Tarjetas> Paciente_Tarjetas { get; set; }
    }
}
