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
    
    public partial class usp_GetOrderForVXpressByOrder_Result
    {
        public int Transaction_ID { get; set; }
        public string Airwaybill_No { get; set; }
        public string Order_No { get; set; }
        public string Consignee_First_Name { get; set; }
        public string Consignee_Last_Name { get; set; }
        public string Consignee_Address1 { get; set; }
        public string Consignee_Address2 { get; set; }
        public string Destination_City { get; set; }
        public string Pincode { get; set; }
        public string State { get; set; }
        public string telephone1 { get; set; }
        public string telephone2 { get; set; }
        public string Vendor_Name { get; set; }
        public string Subvendor_Name { get; set; }
        public string Subvendor_Address { get; set; }
        public string Subvendor_City { get; set; }
        public string Subvendor_Pincode { get; set; }
        public string Subvendor_Phone1 { get; set; }
        public string Pay_Type { get; set; }
        public string Item_Description { get; set; }
        public int Qty { get; set; }
        public Nullable<decimal> collectable_Value { get; set; }
        public Nullable<decimal> product_Value { get; set; }
        public int Actual_Weight { get; set; }
        public int Length { get; set; }
        public int Breadth { get; set; }
        public int Height { get; set; }
    }
}