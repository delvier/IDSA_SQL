﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IDSA_SQL.DB.SQL.Files
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ReportsContainer : DbContext
    {
        public ReportsContainer()
            : base("name=ReportsContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Reports> ReportsSet { get; set; }
        public DbSet<Balance> BalanceSet { get; set; }
        public DbSet<IncomeStatment> IncomeStatmentSet { get; set; }
        public DbSet<CashFlow> CashFlowSet { get; set; }
    }
}