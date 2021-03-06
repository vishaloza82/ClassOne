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
    
    public partial class Add_To_Cart
    {
        public int AddCartId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> PackageId { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public int DeleteStatus { get; set; }
        public bool IsPackageLoosen { get; set; }
        public Nullable<int> CustomerMappingStudentId { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Package Package { get; set; }
        public virtual Product Product { get; set; }
    }
}
