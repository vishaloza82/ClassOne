//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassOne.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tax_History
    {
        public int TaxHistoryId { get; set; }
        public int TaxId { get; set; }
        public double OldTaxPercent { get; set; }
        public double NewTaxPercent { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public int DeleteStatus { get; set; }
    
        public virtual Tax Tax { get; set; }
    }
}