using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class Project : BaseEntity
    {
        public int CustomerId { get; set; }
        public int? ProjectTypeId { get; set; }

        public Customer Customer { get; set; }
        public ProjectType ProjectType { get; set; }
    }
}
