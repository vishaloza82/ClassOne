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
    
    public partial class HomePageContent
    {
        public int HomePageContentId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public Nullable<int> Rank { get; set; }
        public Nullable<int> TileCount { get; set; }
        public Nullable<bool> IsAdvertise { get; set; }
        public string RedirectionPage { get; set; }
        public string ImagePath { get; set; }
        public Nullable<int> DisplayProductOrSubCatOrBrandId { get; set; }
        public string ExtraColumn1 { get; set; }
        public string ExtraColumn2 { get; set; }
        public string ExtraColumn3 { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public int DeleteStatus { get; set; }
    }
}
