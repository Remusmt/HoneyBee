using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class Warehouse : BaseEntity
    {
        public Warehouse()
        {
            Bins = new HashSet<Bin>();
        }
        public string Code { get; set; }
        public string Description { get; set; }
        public Guid? DefaultBinId { get; set; }
        public Bin DefaulftBin { get; set; }
        public ICollection<Bin> Bins { get; set; }
    }
}
