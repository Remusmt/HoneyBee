using HoneyBee.ApplicationCore.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class JournalDetail
    {
        /// <summary>
        /// Holds the ordering of the lines in the transaction
        /// </summary>
        public int JournalLine { get; set; }
        /// <summary>
        /// Reference from the transactions
        /// </summary>
        public Guid TransactionId { get; set; }
        /// <summary>
        /// Reference from the transactionDetail
        /// </summary>
        public Guid? TransactionDetalId { get; set; }
        /// <summary>
        /// A reference from the charts of account
        /// </summary>
        public Guid AccountId { get; set; }
        /// <summary>
        /// Holds reference from tax
        /// </summary>
        public Guid? TaxId { get; set; }
        /// <summary>
        /// Holds reference to the organisation table
        /// </summary>
        public Guid? OrganisationId { get; set; }
        /// <summary>
        /// Holds reference to category
        /// </summary>
        public Guid? CostcenterId { get; set; }
        /// <summary>
        /// A date for when the transaction happened
        /// </summary>
        public DateTime TransactionDate { get; set; }
        /// <summary>
        /// A date for when the transaction was captured into the system
        /// </summary>
        public DateTime EnteredDate { get; set; }
        /// <summary>
        /// A description about the entery
        /// </summary>
        public string Memo { get; set; }
        /// <summary>
        /// Transaction amount in company's currency
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Amount b4 conversion
        /// </summary>
        public decimal CurrencyAmount { get; set; }
        /// <summary>
        /// Depending on the account type the accounting engine will determine if it's a debit or a credit
        /// </summary>
        public decimal Debit { get; set; }
        /// <summary>
        /// Depending on the account type the accounting engine will determine if it's a debit or a credit
        /// </summary>
        public decimal Credit { get; set; }
        /// <summary>
        /// This marks this record as posted to the financial records
        /// A recored marked posted will add to the financial statements' amounts
        /// </summary>
        public bool Posted { get; set; }
        /// <summary>
        /// This marks this record as deleted
        /// </summary>
        public bool Deleted { get; set; }


        public ChartofAccount ChartofAccount { get; set; }
        public Transaction Transaction { get; set; }
        public TransactionDetail TransactionDetail { get; set; }
        public Tax Tax { get; set; }
        public Entity Organisation { get; set; }
        public Costcenter Costcenter { get; set; }
    }
}
