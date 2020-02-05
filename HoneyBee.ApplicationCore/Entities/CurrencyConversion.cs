using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    /// <summary>
    /// Holds conversion rate against company currency
    /// </summary>
    public class CurrencyConversion
    {
        public Guid? CurrencyId { get; set; }
        public Currency Currency { get; set; }
        /// <summary>
        /// [1][Company Currency] = [x] [this.Currency]
        /// </summary>
        public decimal Rate { get; set; }
    }
}
