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
    
    public partial class Orders_Mapping_Product_Package_Mapping_Products
    {
        public int Orders_Mapping_Product_Package_Mapping_ProductId { get; set; }
        public Nullable<int> OrderMappingProductPackageId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> ActualPrice { get; set; }
        public Nullable<decimal> DiscountPercent { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public Nullable<decimal> SGst { get; set; }
        public Nullable<decimal> CGst { get; set; }
        public Nullable<decimal> IGst { get; set; }
        public Nullable<decimal> SGstAmount { get; set; }
        public Nullable<decimal> CGstAmount { get; set; }
        public Nullable<decimal> IGstAmount { get; set; }
        public Nullable<decimal> ExcludingTaxPrice { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public int DeleteStatus { get; set; }
        public bool AvailableForDelivery { get; set; }
    }
}