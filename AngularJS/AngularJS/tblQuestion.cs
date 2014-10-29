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
    
    public partial class tblQuestion
    {
        public tblQuestion()
        {
            this.tblAuditComments = new HashSet<tblAuditComment>();
            this.tblAuditComments1 = new HashSet<tblAuditComment>();
            this.tblChklstCntrlTypes = new HashSet<tblChklstCntrlType>();
            this.tblCorrectiveActions = new HashSet<tblCorrectiveAction>();
            this.tblImages = new HashSet<tblImage>();
        }
    
        public int QuestionId { get; set; }
        public string QuestionSeries { get; set; }
        public string Question { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public int CheckListId { get; set; }
        public Nullable<int> PossibleScore { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> GroupHeaderID { get; set; }
        public Nullable<int> Type { get; set; }
        public string Guidance { get; set; }
    
        public virtual ICollection<tblAuditComment> tblAuditComments { get; set; }
        public virtual ICollection<tblAuditComment> tblAuditComments1 { get; set; }
        public virtual tblCheckList tblCheckList { get; set; }
        public virtual ICollection<tblChklstCntrlType> tblChklstCntrlTypes { get; set; }
        public virtual ICollection<tblCorrectiveAction> tblCorrectiveActions { get; set; }
        public virtual tblGroupHeader tblGroupHeader { get; set; }
        public virtual ICollection<tblImage> tblImages { get; set; }
    }
}