using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class Project : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public Guid? ProjectTypeId { get; set; }

        public Customer Customer { get; set; }
        public ProjectType ProjectType { get; set; }
    }
}
