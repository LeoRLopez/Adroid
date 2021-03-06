//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DepositoDeAlimentos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lote
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lote()
        {
            this.FichaInventario = new HashSet<FichaInventario>();
        }
    
        public int IdLote { get; set; }
        public Nullable<System.DateTime> FechaEntrada { get; set; }
        public Nullable<System.DateTime> FechaRetiro { get; set; }
        public Nullable<int> CantidadAlmacenada { get; set; }
        public int IdPresentado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FichaInventario> FichaInventario { get; set; }
        public virtual Presentado Presentado { get; set; }
    }
}
