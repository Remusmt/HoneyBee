using HoneyBee.ApplicationCore.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    /// <summary>
    /// NB currency should only be home currency
    /// </summary>
    public class TaxAgency : Entity
    {
        public TaxAgency()
        {
            Taxes = new HashSet<Tax>();
        }
        public string TaxRegistrationNumber { get; set; }
        public Month Month { get; set; }
        public ReportingFrequency ReportingFrequency { get; set; }
        public ReportingMethod ReportingMethod { get; set; }
        public Guid? PurchasesAccountId { get; set; }
        public Guid? SalesAccountId { get; set; }


        public ChartofAccount PurchasesAccount { get; set; }
        public ChartofAccount SalesAccount { get; set; }

        public ICollection<Tax> Taxes { get; set; }
    }
}
