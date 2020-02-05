using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class Vehicle : BaseEntity
    {
        public string RegistrationNumber { get; set; }
        public string Description { get; set; }
    }
}
