using HoneyBee.ApplicationCore.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    /// <summary>
    /// Done for now
    /// </summary>
    public class Tax : BaseEntity
    {
        public int TaxAgencyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Taxable { get; set; }
        public bool CollectedOnSales { get; set; }
        public decimal SalesRate { get; set; }
        public bool CollectedOnPurchases { get; set; }
        public decimal PurchaseRate { get; set; }
        public bool PurchaseTaxIsReclaimable { get; set; }
        
        public TaxAgency TaxAgency { get; set; }
    }
}
