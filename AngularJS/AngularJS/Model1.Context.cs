﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class asapEntities : DbContext
    {
        public asapEntities()
            : base("name=asapEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tbl_TabletPassCode> tbl_TabletPassCode { get; set; }
        public DbSet<tblAsset> tblAssets { get; set; }
        public DbSet<tblAssignedCompany> tblAssignedCompanies { get; set; }
        public DbSet<tblAssignedLocation> tblAssignedLocations { get; set; }
        public DbSet<tblAuditComment> tblAuditComments { get; set; }
        public DbSet<tblAudit> tblAudits { get; set; }
        public DbSet<tblAuditStatu> tblAuditStatus { get; set; }
        public DbSet<tblCategory> tblCategories { get; set; }
        public DbSet<tblCheckList> tblCheckLists { get; set; }
        public DbSet<tblChklstCntrlType> tblChklstCntrlTypes { get; set; }
        public DbSet<tblControl> tblControls { get; set; }
        public DbSet<tblCorrectiveActionRevision> tblCorrectiveActionRevisions { get; set; }
        public DbSet<tblCorrectiveAction> tblCorrectiveActions { get; set; }
        public DbSet<tblGroupHeader> tblGroupHeaders { get; set; }
        public DbSet<tblGrower> tblGrowers { get; set; }
        public DbSet<tblImage> tblImages { get; set; }
        public DbSet<tblLocation> tblLocations { get; set; }
        public DbSet<tblNonUser> tblNonUsers { get; set; }
        public DbSet<tblQuestion> tblQuestions { get; set; }
        public DbSet<tblReportType> tblReportTypes { get; set; }
        public DbSet<tblRole> tblRoles { get; set; }
        public DbSet<tblState> tblStates { get; set; }
        public DbSet<tblTemp> tblTemps { get; set; }
        public DbSet<tblThirdparty_types> tblThirdparty_types { get; set; }
        public DbSet<tblUser> tblUsers { get; set; }
    }
}
