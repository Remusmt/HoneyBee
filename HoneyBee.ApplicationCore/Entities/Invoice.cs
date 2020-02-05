using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class Invoice : Transaction
    {
        public Guid? PaymentTermId { get; set; }

        public PaymentTerm PaymentTerm { get; set; }
    }
}
