using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class UOMConversion : BaseEntity
    {
        public int UoMFromId { get; set; }
        public int UoMToId { get; set; }
        public string Description { get; set; }
        public decimal Factor { get; set; }
        public decimal Multiply { get; set; }

        public UnitsofMeasure UOMFrom { get; set; }
        public UnitsofMeasure UOMTo { get; set; }
    }
}
