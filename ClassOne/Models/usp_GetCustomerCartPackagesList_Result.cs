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
    
    public partial class usp_GetCustomerCartPackagesList_Result
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int AddCartId { get; set; }
        public Nullable<int> PackageId { get; set; }
        public int PackQty { get; set; }
        public bool IsPackageLoosen { get; set; }
        public string PackageName { get; set; }
        public string PackageCode { get; set; }
        public string PackImagePath { get; set; }
        public bool IndividualPurchaseFlag { get; set; }
        public Nullable<double> PackCGST { get; set; }
        public Nullable<double> PackSGST { get; set; }
        public Nullable<double> PackIgst { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<bool> ApplyDiscountOnOnlyPackagePurchaseFlag { get; set; }
        public Nullable<double> DiscountPercent { get; set; }
        public string SupplierName { get; set; }
        public string StudName { get; set; }
        public Nullable<int> StandardId { get; set; }
        public string StudClass { get; set; }
        public string StudDivision { get; set; }
        public string StudRollNo { get; set; }
        public int ProductId { get; set; }
        public string ProdName { get; set; }
        public Nullable<double> ProdCGSTPer { get; set; }
        public Nullable<double> ProdSGSTPer { get; set; }
        public Nullable<double> ProdIGSTPer { get; set; }
        public decimal ProdActualPrice { get; set; }
        public Nullable<decimal> ProdDiscountedAmount { get; set; }
        public Nullable<decimal> ProdCGSTAmount { get; set; }
        public Nullable<decimal> ProdSGSTAmount { get; set; }
        public Nullable<decimal> ProdIGSTAmount { get; set; }
        public Nullable<decimal> ProdNonTaxAmount { get; set; }
        public int ProductQty { get; set; }
        public bool ProdSelected { get; set; }
        public Nullable<int> ProdDeliveryWithin { get; set; }
        public string ProdDImagePath { get; set; }
        public Nullable<decimal> ProdDiscountPercent { get; set; }
        public Nullable<int> ShippingCharge { get; set; }
    }
}
