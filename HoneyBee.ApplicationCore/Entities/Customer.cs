using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class Customer:Entity 
    {
        public Customer()
        {
        }

        public Guid? SalesRepId { get; set; }
        public Guid? TaxId { get; set; }

        public SalesRep SalesRep { get; set; }
        public Tax Tax { get; set; }

    }
}
