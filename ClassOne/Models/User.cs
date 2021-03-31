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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Backend_Login_Details = new HashSet<Backend_Login_Details>();
            this.Status_Assign_Task = new HashSet<Status_Assign_Task>();
        }
    
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public System.DateTime PasswordChangedDate { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public int DeleteStatus { get; set; }
        public string EmailId { get; set; }
        public Nullable<int> WarehouseId { get; set; }
        public string Pancard { get; set; }
        public string PancardImage { get; set; }
        public string DrivingLicenseNumber { get; set; }
        public string DrivingLicenseImage { get; set; }
        public Nullable<int> SchoolId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Backend_Login_Details> Backend_Login_Details { get; set; }
        public virtual Role1 Role { get; set; }
        public virtual School School { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Status_Assign_Task> Status_Assign_Task { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
