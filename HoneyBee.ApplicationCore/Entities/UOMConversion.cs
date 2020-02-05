using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class UOMConversion
    {
        public Guid UoMFromId { get; set; }
        public Guid UoMToId { get; set; }
        public string Description { get; set; }
        public decimal Factor { get; set; }
        public decimal Multiply { get; set; }
    }
}
