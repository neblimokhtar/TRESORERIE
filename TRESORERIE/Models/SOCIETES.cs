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
    
    public partial class SOCIETES
    {
        public SOCIETES()
        {
            this.BUDGETS = new HashSet<BUDGETS>();
            this.DEPENSES = new HashSet<DEPENSES>();
            this.FACTURATIONS = new HashSet<FACTURATIONS>();
            this.PROJETS = new HashSet<PROJETS>();
        }
    
        public int ID { get; set; }
        public string NOM { get; set; }
        public string CODE_ACCES { get; set; }
    
        public virtual ICollection<BUDGETS> BUDGETS { get; set; }
        public virtual ICollection<DEPENSES> DEPENSES { get; set; }
        public virtual ICollection<FACTURATIONS> FACTURATIONS { get; set; }
        public virtual ICollection<PROJETS> PROJETS { get; set; }
    }
}
