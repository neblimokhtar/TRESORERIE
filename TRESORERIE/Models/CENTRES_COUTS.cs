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
    
    public partial class CENTRES_COUTS
    {
        public CENTRES_COUTS()
        {
            this.ACHATS_PREVISIONNELS = new HashSet<ACHATS_PREVISIONNELS>();
            this.BUDGETS = new HashSet<BUDGETS>();
            this.DEPENSES = new HashSet<DEPENSES>();
        }
    
        public int ID { get; set; }
        public string CODE { get; set; }
        public string LIBELLE { get; set; }
        public Nullable<int> CATEGORIE { get; set; }
    
        public virtual ICollection<ACHATS_PREVISIONNELS> ACHATS_PREVISIONNELS { get; set; }
        public virtual ICollection<BUDGETS> BUDGETS { get; set; }
        public virtual CATEGORIES_CENTRES_COUTS CATEGORIES_CENTRES_COUTS { get; set; }
        public virtual ICollection<DEPENSES> DEPENSES { get; set; }
    }
}
