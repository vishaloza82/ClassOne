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
    
    public partial class CustomerOrder_Mapping_ShippingStatus
    {
        public int CustomerOrderMappingShippingStatusId { get; set; }
        public int OrderId { get; set; }
        public int ShippingStatusId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public int DeletStatus { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual ShippingStatu ShippingStatu { get; set; }
    }
}
