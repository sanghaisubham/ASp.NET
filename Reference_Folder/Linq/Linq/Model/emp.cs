//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Linq.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class emp
    {
        public int code { get; set; }
        public string name { get; set; }
        public Nullable<decimal> salary { get; set; }
        public Nullable<int> deptid { get; set; }
    
        public virtual deptt deptt { get; set; }
    }
}