//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DhulikhelSHS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class WBPlan
    {
        public int WBPlanID { get; set; }
        public string WBPlanName { get; set; }
        public string WBPlanDesc { get; set; }
        public Nullable<int> WBCategoryID { get; set; }
        public Nullable<int> WBID { get; set; }
    
        public virtual WardBhela WardBhela { get; set; }
        public virtual WBCategory WBCategory { get; set; }
    }
}