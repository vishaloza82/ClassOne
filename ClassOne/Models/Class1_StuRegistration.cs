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
    
    public partial class Class1_StuRegistration
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string mobilenumber { get; set; }
        public Nullable<int> SchoolId { get; set; }
        public Nullable<int> gradeID { get; set; }
        public string password { get; set; }
        public string Division { get; set; }
        public string Email { get; set; }
        public Nullable<int> RoleId { get; set; }
    
        public virtual Class1Roles Class1Roles { get; set; }
    }
}