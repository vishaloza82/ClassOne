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
    
    public partial class usp_GetOrdersProductReport_Result
    {
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string ISBN10 { get; set; }
        public string ISBN13 { get; set; }
        public int ExtraCol1Int { get; set; }
        public int ExtraCol2Int { get; set; }
        public string ExtraCol1Varchar { get; set; }
        public string ExtraCol2Varchar { get; set; }
        public string Publisher { get; set; }
        public Nullable<int> StockQuantity { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<decimal> CollectedAmount { get; set; }
    }
}
