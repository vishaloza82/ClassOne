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
    
    public partial class SchoolBoard_Mapping_Standard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SchoolBoard_Mapping_Standard()
        {
            this.Package_Mapping_SchoolBoardStandard = new HashSet<Package_Mapping_SchoolBoardStandard>();
        }
    
        public int SchoolBoardMappingStandardId { get; set; }
        public int SchoolMappingBoardId { get; set; }
        public int StandardId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public int DeleteStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Package_Mapping_SchoolBoardStandard> Package_Mapping_SchoolBoardStandard { get; set; }
        public virtual School_Mapping_Board School_Mapping_Board { get; set; }
        public virtual Standard Standard { get; set; }
    }
}
