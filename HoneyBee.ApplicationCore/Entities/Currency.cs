using HoneyBee.ApplicationCore.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class Currency
    {
        public Currency()
        {
            CurrencyConversions = new HashSet<CurrencyConversion>();
        }
        [Key]
        public int Id { get; set; }
        public string ISOCode { get; set; }
        public string Description { get; set; }
        public int CountryId { get; set; }
        public FormatSeparator ThousandSeparator { get; set; }
        public FormatSeparator DecimalSeparator { get; set; }
        public string GroupingFormat { get; set; }
        public int DecimalPlaces { get; set; }

        public Country Country { get; set; }

        public ICollection<CurrencyConversion> CurrencyConversions { get; set; }
    }
}
