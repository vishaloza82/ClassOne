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
    
    public partial class COD_Payment_Details
    {
        public int cod_payment_detailsid { get; set; }
        public string awb_number { get; set; }
        public string order_no { get; set; }
        public System.DateTime pickup_date { get; set; }
        public System.DateTime delivery_date { get; set; }
        public double cod_amount { get; set; }
        public string utrn_no { get; set; }
        public System.DateTime payment_date { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
    }
}