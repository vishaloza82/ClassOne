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
    
    public partial class usp_GetCustomerWishlist_Result
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string BrandName { get; set; }
        public string ImagePath { get; set; }
        public Nullable<decimal> ActualPrice { get; set; }
        public Nullable<double> DiscountPercent { get; set; }
        public Nullable<double> DiscountPrice { get; set; }
        public int Quantity { get; set; }
        public string PackageCode { get; set; }
        public Nullable<int> NumberOfProducts { get; set; }
        public string Type { get; set; }
        public Nullable<double> Rating { get; set; }
    }
}
