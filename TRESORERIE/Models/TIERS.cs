//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TRESORERIE.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIERS
    {
        public TIERS()
        {
            this.DEPENSES = new HashSet<DEPENSES>();
            this.PROJETS = new HashSet<PROJETS>();
            this.PROJETS1 = new HashSet<PROJETS>();
        }
    
        public int ID { get; set; }
        public string RAISON_SOCIALE { get; set; }
        public string TYPE { get; set; }
    
        public virtual ICollection<DEPENSES> DEPENSES { get; set; }
        public virtual ICollection<PROJETS> PROJETS { get; set; }
        public virtual ICollection<PROJETS> PROJETS1 { get; set; }
    }
}
