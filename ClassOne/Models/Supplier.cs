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
    
    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            this.Orders = new HashSet<Order>();
            this.Orders_Mapping_Product_Package = new HashSet<Orders_Mapping_Product_Package>();
            this.Package_Commission_Supplier = new HashSet<Package_Commission_Supplier>();
            this.Packages = new HashSet<Package>();
            this.Product_Commission_Supplier = new HashSet<Product_Commission_Supplier>();
            this.Product_Mapping_Suppliers = new HashSet<Product_Mapping_Suppliers>();
            this.Product_Mapping_Suppliers_SKUCode = new HashSet<Product_Mapping_Suppliers_SKUCode>();
            this.Products = new HashSet<Product>();
            this.ShippingCharge_Mapping_Supplier = new HashSet<ShippingCharge_Mapping_Supplier>();
            this.Supplier_Emails = new HashSet<Supplier_Emails>();
            this.SupplierContactNumbers = new HashSet<SupplierContactNumber>();
            this.Suppliers_Login = new HashSet<Suppliers_Login>();
        }
    
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string LogoPath { get; set; }
        public string Website { get; set; }
        public string StreetAddress { get; set; }
        public string ContactPersonFirstName { get; set; }
        public string ContactPersonLastName { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<int> StateId { get; set; }
        public Nullable<int> CityId { get; set; }
        public string PinCode { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> PasswordChangedDate { get; set; }
        public string GSTSIN { get; set; }
        public string GSTSINImage { get; set; }
        public string PAN { get; set; }
        public string PANImage { get; set; }
        public Nullable<int> WarehouseId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public int DeleteStatus { get; set; }
        public string SupplierShortName { get; set; }
    
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders_Mapping_Product_Package> Orders_Mapping_Product_Package { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Package_Commission_Supplier> Package_Commission_Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Package> Packages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Commission_Supplier> Product_Commission_Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Mapping_Suppliers> Product_Mapping_Suppliers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Mapping_Suppliers_SKUCode> Product_Mapping_Suppliers_SKUCode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShippingCharge_Mapping_Supplier> ShippingCharge_Mapping_Supplier { get; set; }
        public virtual State State { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supplier_Emails> Supplier_Emails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplierContactNumber> SupplierContactNumbers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Suppliers_Login> Suppliers_Login { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
