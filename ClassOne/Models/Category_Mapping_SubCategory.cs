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
    
    public partial class Category_Mapping_SubCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category_Mapping_SubCategory()
        {
            this.Product_Mapping_CateogoryMappingSubCategory = new HashSet<Product_Mapping_CateogoryMappingSubCategory>();
        }
    
        public int CategoryMappingSubCategoryId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public int DeleteStatus { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Mapping_CateogoryMappingSubCategory> Product_Mapping_CateogoryMappingSubCategory { get; set; }
    }
}