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
    
    public partial class usp_GetPackageProductList_Result
    {
        public int ProductId { get; set; }
        public string ProdName { get; set; }
        public Nullable<int> ProdInventoryCount { get; set; }
        public string ProdDescription { get; set; }
        public string ProdImage { get; set; }
        public decimal ProdActualPrice { get; set; }
        public decimal ProdDiscountPercentage { get; set; }
        public Nullable<decimal> ProdDiscountedPrice { get; set; }
        public Nullable<double> ProdCGstPercent { get; set; }
        public Nullable<double> ProdSGstPercent { get; set; }
        public Nullable<double> ProdIGstPercent { get; set; }
        public int ProdCGstAmount { get; set; }
        public int ProdSGstAmount { get; set; }
        public int ProdIGstAmount { get; set; }
        public Nullable<bool> IsSelected { get; set; }
        public bool ProdIsMandatoryFlag { get; set; }
        public bool ProdChangeQuantityFlag { get; set; }
        public int ProdMinPurchaseLimit { get; set; }
        public int ProdMaxPurchaseLimit { get; set; }
        public int ProdQuantity { get; set; }
        public int CategoryId { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public bool SaleClubbed { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public string Extra4 { get; set; }
    }
}
