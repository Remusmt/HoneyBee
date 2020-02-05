using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class Address : BaseEntity
    {
        public string TextAddress { get; set; }

        public string TextAddress1 { get; set; }

        public string PostalCode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(!string.IsNullOrWhiteSpace(this.TextAddress) ? this.TextAddress : string.Empty);
            stringBuilder.Append(!string.IsNullOrWhiteSpace(this.TextAddress1) ? " " + this.TextAddress1.Trim() + ", " : (!string.IsNullOrWhiteSpace(this.TextAddress) ? ", " : string.Empty));
            stringBuilder.Append(!string.IsNullOrWhiteSpace(this.PostalCode) ? this.PostalCode + ", " : string.Empty);
            stringBuilder.Append(!string.IsNullOrWhiteSpace(this.City) ? this.City.Trim() + ", " : string.Empty);
            stringBuilder.Append(!string.IsNullOrWhiteSpace(this.Country) ? this.Country.Trim() : string.Empty);
            return stringBuilder.ToString();
        }
    }
}
