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
    
    public partial class Coupon1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Coupon1()
        {
            this.Customer_Coupon = new HashSet<Customer_Coupon>();
        }
    
        public int CouponId { get; set; }
        public decimal CouponAmount { get; set; }
        public string CouponDescription { get; set; }
        public decimal OrderPriceFrom { get; set; }
        public decimal OrderPriceTo { get; set; }
        public string CouponCode { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public int DeleteStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Coupon> Customer_Coupon { get; set; }
    }
}
