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
    
    public partial class usp_GetAllOrdersPaginatedForSuerAdmin_Result
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int CustomerMappingStudentId { get; set; }
        public string OrderNumber { get; set; }
        public string OrderDate { get; set; }
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public string OrderBy { get; set; }
        public string OrderFor { get; set; }
        public int StandardId { get; set; }
        public string StandardName { get; set; }
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public string OrderAddress { get; set; }
        public string MobileNumber { get; set; }
        public Nullable<int> ShippingStatusId { get; set; }
        public string ShippingStatus { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public Nullable<decimal> DiscountedPrice { get; set; }
        public Nullable<decimal> FinalTotal { get; set; }
        public Nullable<decimal> ShippingCharges { get; set; }
        public Nullable<decimal> SSCommissionPrice { get; set; }
        public int PaymentFormatId { get; set; }
        public string PaymentFormat { get; set; }
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
    }
}