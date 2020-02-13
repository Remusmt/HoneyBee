using HoneyBee.ApplicationCore.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    /// <summary>
    /// This is the source of all data
    /// </summary>
    public class TransactionDetail : BaseEntity
    {
        public TransactionDetail()
        {
            JournalDetails = new HashSet<JournalDetail>();
        }
        /// <summary>
        /// This is used to order items on form and on print.
        /// </summary>
        public int LineNumber { get; set; }
        public int TransactionId { get; set; }
        public DateTime EnteredDate { get; set; }
        public DateTime TransactionDate { get; set; }
        public int? TaxItemId { get; set; }
        /// <summary>
        /// Costcenters
        /// </summary>
        public int? CostcenterId { get; set; }
        public int? UOMId { get; set; }
        public int? ItemId { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
        public DateTime ServiceDate { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal Total { get; set; }
        public string Custom1 { get; set; }
        public string Custom2 { get; set; }


        public Transaction Transaction { get; set; }
        public Tax Tax { get; set; }
        public UnitsofMeasure UnitsofMeasure { get; set; }
        public Item Item { get; set; }
        public Costcenter Costcenter { get; set; }

        public ICollection<JournalDetail> JournalDetails { get; set; }

    }
}
