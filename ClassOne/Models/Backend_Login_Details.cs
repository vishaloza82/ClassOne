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
    
    public partial class Backend_Login_Details
    {
        public int BackendLoginDetailsId { get; set; }
        public int UserId { get; set; }
        public System.DateTime LastLoginDate { get; set; }
        public string LastLoginIp { get; set; }
        public Nullable<System.DateTime> LogoutTime { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public int DeleteStatus { get; set; }
    
        public virtual User User { get; set; }
    }
}
