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
    
    public partial class usp_GetPAckageDetailsWithProductList_Result
    {
        public decimal ProdActualPrice { get; set; }
        public decimal ProdDiscountPercentage { get; set; }
        public Nullable<decimal> UnitDiscountPrice { get; set; }
        public Nullable<double> ProdCGstPercent { get; set; }
        public Nullable<double> ProdSGstPercent { get; set; }
        public Nullable<double> ProdIGstPercent { get; set; }
        public int ProdCGstAmount { get; set; }
        public int ProdSGstAmount { get; set; }
        public int ProdIGstAmount { get; set; }
        public Nullable<double> PackCGST { get; set; }
        public Nullable<double> PackSGST { get; set; }
        public Nullable<double> PackIGST { get; set; }
        public int PackCGstAmount { get; set; }
        public int PackSGstAmount { get; set; }
        public int PackIGstAmount { get; set; }
        public int ProductId { get; set; }
        public string ProdImage { get; set; }
        public Nullable<int> ProdInventoryCount { get; set; }
        public string ProdDescription { get; set; }
        public string ProdName { get; set; }
        public Nullable<bool> IsSelected { get; set; }
        public bool ProdChangeQuantityFlag { get; set; }
        public bool ProdIsMandatoryFlag { get; set; }
        public int ProdMinPurchaseLimit { get; set; }
        public int ProdMaxPurchaseLimit { get; set; }
        public int ProdQuantity { get; set; }
        public bool ProdIndividualPurchaseFlag { get; set; }
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public Nullable<int> MaxAge { get; set; }
        public Nullable<int> MinAge { get; set; }
        public string PackageCode { get; set; }
        public string ReplacementPolicy { get; set; }
        public string WarrantyPolicy { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public string SupplierName { get; set; }
        public Nullable<bool> IsWishList { get; set; }
        public Nullable<double> DiscountPercent { get; set; }
        public bool ApplyDiscountOnLoosePurchaseFlag { get; set; }
        public bool PurchaseAllowFlag { get; set; }
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
    }
}
