using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class SalesRep: BaseEntity
    {
        public int EntityId { get; set; }
        public Entity Entity { get; set; }
    }
}
