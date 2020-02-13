using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class CompanyPreference : BaseEntity
    {
        public bool ChargeTax { get; set; }
        public int? DefaultTaxId { get; set; }
        public bool TrackTime { get; set; }
        public int? DefaultShippingMethodId { get; set; }
        public int? DefualtFOBId { get; set; }
        public bool UsePricingRules { get; set; }
        public bool UseMultipleCurrencies { get; set; }
        public int? HomeCurrencyId { get; set; }
    }
}
