using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class CompanyPreference : BaseEntity
    {
        public bool ChargeTax { get; set; }
        public Guid? DefaultTaxId { get; set; }
        public bool TrackTime { get; set; }
        public Guid? DefaultShippingMethodId { get; set; }
        public Guid? DefualtFOBId { get; set; }
        public bool UsePricingRules { get; set; }
        public bool UseMultipleCurrencies { get; set; }
        public Guid? HomeCurrencyId { get; set; }

        public Tax DefaultTax { get; set; }
        public ShippingMethod DefaultShippingMethod { get; set; }
        public FOB DefaultFOB { get; set; }
        public Currency HomeCurrency { get; set; }
    }
}
