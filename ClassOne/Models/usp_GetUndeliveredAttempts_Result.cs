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
    
    public partial class usp_GetUndeliveredAttempts_Result
    {
        public int Order_Mapping_Undelivered_ReasonId { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<int> Undelivered_ReasonId { get; set; }
        public string Comment { get; set; }
        public string AttemptDate { get; set; }
        public string Reason { get; set; }
    }
}
