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
    using System.Collections.Generic;
    
    public partial class OrderStatusHistory
    {
        public int OrderStatusHistoryId { get; set; }
        public string AuditMode { get; set; }
        public Nullable<System.DateTime> AuditDate { get; set; }
        public Nullable<int> OrderStatusId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> DeletStatus { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<int> ShippingStatusId { get; set; }
    }
}