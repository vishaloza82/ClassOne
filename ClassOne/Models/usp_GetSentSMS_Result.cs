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
    
    public partial class usp_GetSentSMS_Result
    {
        public int CustomerSMS_Id { get; set; }
        public string MobileNumber { get; set; }
        public string SMS_Text { get; set; }
        public string SMS_ProviderId { get; set; }
        public string SMS_SendStatus { get; set; }
        public string SMSSentDate { get; set; }
    }
}
