using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class Invoice : Transaction
    {
        public int? PaymentTermId { get; set; }
        public int? CustomerId { get; set; }

        public PaymentTerm PaymentTerm { get; set; }
        public Customer Customer { get; set; }
    }
}
