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
    
    public partial class usp_GetPackageMappingProducList_Result
    {
        public Nullable<int> PackageId { get; set; }
        public string PackageName { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string SKUId { get; set; }
        public string ImagePath { get; set; }
        public Nullable<bool> ProductStatus { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<bool> IsMandatoryFlag { get; set; }
        public Nullable<bool> ChangeQuantityFlag { get; set; }
        public Nullable<int> MaxPurchaseLimit { get; set; }
        public Nullable<int> MinPurchaseLimit { get; set; }
    }
}
