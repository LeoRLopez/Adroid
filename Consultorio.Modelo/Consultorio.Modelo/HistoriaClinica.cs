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
    
    public partial class HistoriaClinica
    {
        public int IdHistoriaClinica { get; set; }
        public System.DateTime FechaAtencion { get; set; }
        public string Descripcion { get; set; }
        public int IdPaciente { get; set; }
        public Nullable<int> IdTurno { get; set; }
    
        public virtual Paciente Paciente { get; set; }
        public virtual Turno Turno { get; set; }
    }
}
