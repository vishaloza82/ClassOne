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
    
    public partial class Order_Mapping_Tracking_Number
    {
        public int Order_Mapping_Tracking_NumberId { get; set; }
        public int OrderId { get; set; }
        public string Tracking_Number { get; set; }
        public string Status { get; set; }
        public string Courier { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public int DeleteStatus { get; set; }
    }
}
