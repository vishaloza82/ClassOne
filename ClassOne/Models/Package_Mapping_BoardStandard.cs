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
    
    public partial class Package_Mapping_BoardStandard
    {
        public int PackageMappingBoardStandardId { get; set; }
        public int PackageId { get; set; }
        public int BoardMappingStandardId { get; set; }
        public Nullable<int> SemesterId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public int DeleteStatus { get; set; }
    
        public virtual Board_Mapping_Standard Board_Mapping_Standard { get; set; }
        public virtual Package Package { get; set; }
        public virtual Semester Semester { get; set; }
    }
}