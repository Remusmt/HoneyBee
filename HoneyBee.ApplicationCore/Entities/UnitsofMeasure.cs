using HoneyBee.ApplicationCore.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class UnitsofMeasure : BaseEntity
    {
        public UnitsofMeasure()
        {
            UOMConversionsFrom = new HashSet<UOMConversion>();
            UOMConversionsTo = new HashSet<UOMConversion>();
        }
        public UOMType UOMType { get; set; }
        public string Abbreviation { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool ReadOnly { get; set; }
        public ICollection<UOMConversion> UOMConversionsFrom { get; set; }
        public ICollection<UOMConversion> UOMConversionsTo { get; set; }

    }
}
