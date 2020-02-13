using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class Bin : BaseEntity
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public bool AvailableForSale { get; set; }
        public bool Pickable { get; set; }
        public bool Receivable { get; set; }
        public int WarehouseId { get; set; }

        public Warehouse Warehouse { get; set; }
    }
}
