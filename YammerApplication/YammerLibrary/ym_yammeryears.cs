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
    
    public partial class ym_yammeryears
    {
        public int id { get; set; }
        public Nullable<int> ymyear { get; set; }
        public Nullable<int> sequence { get; set; }
        public Nullable<bool> ToDownload { get; set; }
        public Nullable<bool> ToProcess { get; set; }
        public Nullable<bool> ToCompress { get; set; }
        public Nullable<bool> ToRun { get; set; }
        public string ProcessedBy { get; set; }
        public Nullable<bool> ToSPUpload { get; set; }
        public Nullable<bool> ToDeDuplicate { get; set; }
    }
}
