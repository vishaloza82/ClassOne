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
    
    public partial class Customer_Mapping_OTP
    {
        public int Customer_Mapping_OTPId { get; set; }
        public string OTP { get; set; }
        public int CustomerId { get; set; }
        public string MobileNumber { get; set; }
        public System.DateTime OTPStartTime { get; set; }
        public System.DateTime OTPEndTime { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public int DeleteStatus { get; set; }
    }
}
