//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace STPS.SIRCE.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class NormasCompetencia
    {
        public NormasCompetencia()
        {
            this.NormaTrabajador = new HashSet<NormaTrabajador>();
        }
    
        public int NormaCompetenciaID { get; set; }
        public string Clave { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<NormaTrabajador> NormaTrabajador { get; set; }
    }
}
