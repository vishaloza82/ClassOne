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
    
    public partial class GetOrderProducts_Result
    {
        public Nullable<int> ProductId { get; set; }
        public int Quantity { get; set; }
        public Nullable<decimal> ActualPrice { get; set; }
        public Nullable<double> DiscountedPrice { get; set; }
        public Nullable<double> DiscountPercent { get; set; }
        public string BrandName { get; set; }
        public decimal SingleProductPrice { get; set; }
        public Nullable<double> SingleProductDiscountPercentPrice { get; set; }
        public string ImagePath { get; set; }
    }
}