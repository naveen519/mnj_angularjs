//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularJS
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblControl
    {
        public tblControl()
        {
            this.tblChklstCntrlTypes = new HashSet<tblChklstCntrlType>();
        }
    
        public int ControlId { get; set; }
        public string Controlname { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual ICollection<tblChklstCntrlType> tblChklstCntrlTypes { get; set; }
    }
}
