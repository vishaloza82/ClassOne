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
    
    public partial class usp_GetOrderProductsOLD_Result
    {
        public string ItemName { get; set; }
        public int Qty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> CGstAmount { get; set; }
        public Nullable<decimal> SGstAmount { get; set; }
        public Nullable<decimal> IGstAmount { get; set; }
        public Nullable<decimal> ExcludingTaxPrice { get; set; }
        public Nullable<double> CGst { get; set; }
        public Nullable<double> SGst { get; set; }
        public Nullable<double> IGst { get; set; }
    }
}
