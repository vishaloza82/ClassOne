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
    
    public partial class ContactUsDetail
    {
        public int ContactUsDetailId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> ContactUsIssueId { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Type { get; set; }
        public Nullable<System.DateTime> createddate { get; set; }
        public Nullable<System.DateTime> updateddate { get; set; }
        public Nullable<bool> deletestatus { get; set; }
    
        public virtual ContactUsIssue ContactUsIssue { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Customer Customer1 { get; set; }
    }
}
