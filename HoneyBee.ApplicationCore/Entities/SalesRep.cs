using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class SalesRep: BaseEntity
    {
        public Guid PersonId { get; set; }
        public Entity Person { get; set; }
    }
}
