using HoneyBee.ApplicationCore.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    /// <summary>
    /// Holds all transactions, journals, sales, purchases etc.
    /// </summary>
    public class Transaction : BaseEntity
    {
        public Transaction()
        {
            TransactionDetails = new HashSet<TransactionDetail>();
            JournalDetails = new HashSet<JournalDetail>();
        }
        public TransactionType TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime EnteredDate { get; set; }
        public string ReferenceNumber { get; set; }
        public Guid CurrencyId { get; set; }
        public decimal ExcangeRate { get; set; }

        public decimal SubTotal { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalAmount { get; set; }

        public Currency Currency { get; set; }

        public ICollection<TransactionDetail> TransactionDetails { get; set; }
        public ICollection<JournalDetail> JournalDetails { get; set; }
    }
}
