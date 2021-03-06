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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Add_To_Cart = new HashSet<Add_To_Cart>();
            this.Customer_Feedback = new HashSet<Customer_Feedback>();
            this.Customer_Product_Rating = new HashSet<Customer_Product_Rating>();
            this.Customer_Replacement_Order = new HashSet<Customer_Replacement_Order>();
            this.Customer_WishList = new HashSet<Customer_WishList>();
            this.Orders_Mapping_Product_Package = new HashSet<Orders_Mapping_Product_Package>();
            this.Package_Mapping_Products = new HashSet<Package_Mapping_Products>();
            this.Product_Commission_Supplier = new HashSet<Product_Commission_Supplier>();
            this.Product_Discount = new HashSet<Product_Discount>();
            this.Product_History = new HashSet<Product_History>();
            this.Product_Images = new HashSet<Product_Images>();
            this.Product_Mapping_Board = new HashSet<Product_Mapping_Board>();
            this.Product_Mapping_BoardStandard = new HashSet<Product_Mapping_BoardStandard>();
            this.Product_Mapping_CateogoryMappingSubCategory = new HashSet<Product_Mapping_CateogoryMappingSubCategory>();
            this.Product_Mapping_GeneralSpecification = new HashSet<Product_Mapping_GeneralSpecification>();
            this.Product_Mapping_Standard = new HashSet<Product_Mapping_Standard>();
            this.Product_Mapping_Suppliers = new HashSet<Product_Mapping_Suppliers>();
            this.Product_Mapping_Suppliers_SKUCode = new HashSet<Product_Mapping_Suppliers_SKUCode>();
            this.Product_Taxation = new HashSet<Product_Taxation>();
        }
    
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string SKUId { get; set; }
        public int BrandId { get; set; }
        public decimal ActualPrice { get; set; }
        public string Author { get; set; }
        public string WarrantyPolicy { get; set; }
        public string ReplacementPolicy { get; set; }
        public Nullable<int> MinAge { get; set; }
        public Nullable<int> MaxAge { get; set; }
        public Nullable<int> DeliveryWithin { get; set; }
        public double DiscountPercent { get; set; }
        public string ImagePath { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public int DeleteStatus { get; set; }
        public Nullable<int> ProductTypeId { get; set; }
        public Nullable<int> InventoryCount { get; set; }
        public Nullable<bool> IsReward { get; set; }
        public Nullable<double> SGst { get; set; }
        public Nullable<double> IGst { get; set; }
        public Nullable<double> CGst { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<double> SSCommissionPercent { get; set; }
        public string ProductDeliveryNote { get; set; }
        public bool ClubbedDelivery { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Add_To_Cart> Add_To_Cart { get; set; }
        public virtual Brand Brand { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Feedback> Customer_Feedback { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Product_Rating> Customer_Product_Rating { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Replacement_Order> Customer_Replacement_Order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_WishList> Customer_WishList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders_Mapping_Product_Package> Orders_Mapping_Product_Package { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Package_Mapping_Products> Package_Mapping_Products { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Commission_Supplier> Product_Commission_Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Discount> Product_Discount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_History> Product_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Images> Product_Images { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Mapping_Board> Product_Mapping_Board { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Mapping_BoardStandard> Product_Mapping_BoardStandard { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Mapping_CateogoryMappingSubCategory> Product_Mapping_CateogoryMappingSubCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Mapping_GeneralSpecification> Product_Mapping_GeneralSpecification { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Mapping_Standard> Product_Mapping_Standard { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Mapping_Suppliers> Product_Mapping_Suppliers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Mapping_Suppliers_SKUCode> Product_Mapping_Suppliers_SKUCode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_Taxation> Product_Taxation { get; set; }
        public virtual Product_Type Product_Type { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
