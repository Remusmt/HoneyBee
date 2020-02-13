using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class EntityAddress : BaseEntity
    {
        public int AddressId { get; set; }
        public int EntityId { get; set; }
        

        public Address Address { get; set; }
        public Entity Entity { get; set; }
    }
}
