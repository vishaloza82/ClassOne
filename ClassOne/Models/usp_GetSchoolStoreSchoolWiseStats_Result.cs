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
    
    public partial class usp_GetSchoolStoreSchoolWiseStats_Result
    {
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public Nullable<int> Orders { get; set; }
        public Nullable<int> AllOrdersCount { get; set; }
        public Nullable<decimal> OrderPer { get; set; }
        public Nullable<decimal> OrderPrice { get; set; }
        public Nullable<double> AllOrderAmount { get; set; }
        public Nullable<double> AmountPer { get; set; }
    }
}
