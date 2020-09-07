using System.ComponentModel.DataAnnotations;

namespace HoneyBee.ApplicationCore.Entities
{
    /// <summary>
    /// Holds conversion rate against company currency
    /// </summary>
    public class CurrencyConversion
    {
        [Key]
        public int Id { get; set; }
        public int CurrencyId { get; set; }
        /// <summary>
        /// [1][Company Currency] = [x] [this.Currency]
        /// </summary>
        public decimal Rate { get; set; }

        public Currency Currency { get; set; }

    }
}
