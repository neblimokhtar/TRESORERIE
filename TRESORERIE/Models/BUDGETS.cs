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
    
    public partial class BUDGETS
    {
        public int ID { get; set; }
        public decimal MONTANT_HT { get; set; }
        public Nullable<int> PROJET { get; set; }
        public Nullable<int> CENTRE_COUT { get; set; }
        public Nullable<int> SOCIETE { get; set; }
    
        public virtual CENTRES_COUTS CENTRES_COUTS { get; set; }
        public virtual PROJETS PROJETS { get; set; }
        public virtual SOCIETES SOCIETES { get; set; }
    }
}