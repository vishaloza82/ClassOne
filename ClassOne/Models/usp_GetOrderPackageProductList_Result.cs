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
    
    public partial class usp_GetOrderPackageProductList_Result
    {
        public int OrderMappingProductPackageId { get; set; }
        public int ItemId { get; set; }
        public string ImagePath { get; set; }
        public string BrandName { get; set; }
        public string Name { get; set; }
        public string PackageCode { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public string PackExtra1 { get; set; }
        public string PackExtra2 { get; set; }
        public string PackExtra3 { get; set; }
        public string PackExtra4 { get; set; }
        public string PackExtra5 { get; set; }
        public int Orders_Mapping_Product_Package_Mapping_ProductId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImagePath { get; set; }
        public Nullable<int> ProductQuantity { get; set; }
        public Nullable<decimal> ProductActualPrice { get; set; }
        public Nullable<decimal> ProductDiscountPercent { get; set; }
        public Nullable<decimal> ProductDiscountPrice { get; set; }
        public string BrandName1 { get; set; }
        public Nullable<bool> ProductReplacedFlag { get; set; }
        public Nullable<int> ProductReplacementQuantity { get; set; }
        public Nullable<bool> AllowProductReplacementFlag { get; set; }
        public Nullable<bool> AvailableForDelivery { get; set; }
        public string ProdExtra1 { get; set; }
        public string ProdExtra2 { get; set; }
        public string ProdExtra3 { get; set; }
        public string ProdExtra4 { get; set; }
        public string ProdExtra5 { get; set; }
    }
}
