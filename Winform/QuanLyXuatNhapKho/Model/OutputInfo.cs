//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class OutputInfo
    {
        public int Id { get; set; }
        public int IdOutput { get; set; }
        public int IdObject { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<double> OutputPrice { get; set; }
    
        public virtual Object Object { get; set; }
        public virtual Output Output { get; set; }
    }
}