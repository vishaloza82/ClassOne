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
    
    public partial class Order_Price
    {
        public int OrderPriceId { get; set; }
        public int OrderId { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public Nullable<decimal> DiscountedPrice { get; set; }
        public Nullable<decimal> FinalTotal { get; set; }
        public Nullable<decimal> ShippingCharges { get; set; }
        public Nullable<double> ScholarShipPoints { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public int DeleteStatus { get; set; }
        public Nullable<decimal> CGstAmount { get; set; }
        public Nullable<decimal> SGstAmount { get; set; }
        public Nullable<decimal> IGstAmount { get; set; }
        public Nullable<decimal> ExcludingTaxPrice { get; set; }
        public Nullable<decimal> SSCommissionPrice { get; set; }
    
        public virtual Order Order { get; set; }
    }
}