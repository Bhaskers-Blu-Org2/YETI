//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YammerLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class spbatchlistbak
    {
        public int BatchNo { get; set; }
        public int YmYear { get; set; }
        public string GroupName { get; set; }
        public string GroupType { get; set; }
        public string FolderPath { get; set; }
        public Nullable<int> ItemCount { get; set; }
        public string FileName { get; set; }
        public string status { get; set; }
        public Nullable<int> parentBatchNo { get; set; }
        public string processedBy { get; set; }
        public int SPMappingId { get; set; }
        public Nullable<int> TimesTried { get; set; }
    }
}
