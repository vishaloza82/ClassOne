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
    
    public partial class usp_GetSchoolMappingPackageInventory_Result
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public Nullable<int> Package_Inventory_Mapping_Supplier_Mapping_SchoolId { get; set; }
        public Nullable<int> InQuantity { get; set; }
        public Nullable<int> OutQuantity { get; set; }
        public Nullable<int> InStock { get; set; }
        public Nullable<bool> AcceptanceStatus { get; set; }
        public string AcceptanceDate { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<bool> IsLast { get; set; }
    }
}
