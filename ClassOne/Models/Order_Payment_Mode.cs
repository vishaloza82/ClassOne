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
    
    public partial class Order_Payment_Mode
    {
        public int OrderPaymentModeId { get; set; }
        public int OrderId { get; set; }
        public int PaymentFormatId { get; set; }
        public int PaymentStatusId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public int DeleteStatus { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Payment_Format Payment_Format { get; set; }
        public virtual Payment_Status Payment_Status { get; set; }
    }
}
