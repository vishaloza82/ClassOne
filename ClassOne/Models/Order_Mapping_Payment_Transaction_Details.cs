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
    
    public partial class Order_Mapping_Payment_Transaction_Details
    {
        public int Order_Mapping_Payment_Transaction_DetailsId { get; set; }
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public int Payment_FormatId { get; set; }
        public string Payment_Format { get; set; }
        public decimal Order_Amount { get; set; }
        public decimal Receivable_Amount { get; set; }
        public Nullable<decimal> Received_Amount { get; set; }
        public bool Amount_Received_Flag { get; set; }
        public Nullable<System.DateTime> Amount_Received_Date { get; set; }
        public string Bank_TransactionId { get; set; }
        public Nullable<System.DateTime> Bank_Transaction_Date { get; set; }
        public string Note { get; set; }
        public string ErrorFlag { get; set; }
        public string ErrorCondition { get; set; }
        public Nullable<double> VarianceAmount { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public int DeleteStatus { get; set; }
    }
}
