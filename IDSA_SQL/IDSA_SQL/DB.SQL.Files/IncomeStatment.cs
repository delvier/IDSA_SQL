//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class IncomeStatment
    {
        public int Id { get; set; }
        public long Sales { get; set; }
        public long OwnSaleCosts { get; set; }
        public long SalesCost1 { get; set; }
        public long SalesCost2 { get; set; }
        public long EarningsOnSales { get; set; }
        public long OtherOperationalActivity1 { get; set; }
        public long OtherOperationalActivity2 { get; set; }
        public long EBIT { get; set; }
        public long FinancialActivity1 { get; set; }
        public long FinancialActivity2 { get; set; }
        public long OtherCostOrSales { get; set; }
        public long SalesOnEconomicActivity { get; set; }
        public long ExceptionalOccurence { get; set; }
        public long EarningsBeforeTaxes { get; set; }
        public long DiscountinuedOperations { get; set; }
        public long NetParentProfit { get; set; }
    
        public virtual Reports Reports_Id { get; set; }
    }
}