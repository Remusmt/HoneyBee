using System;

namespace HoneyBee.ApplicationCore.Entities
{
    /// <summary>
    /// The single source of truth
    /// Should think of merging this class with transaction details and using 
    /// a field [SystemGenerated] to differentiate between user keyed in data and system generated lines
    /// also (create a category for non posting accounts to use for LPO and other non posting transactions.
    /// or allow nulls for accountId)
    /// </summary>
    public class JournalDetail : BaseEntity
    {
        /// <summary>
        /// Holds the ordering of the lines in the transaction
        /// </summary>
        public int JournalLine { get; set; }
        /// <summary>
        /// Reference from the transactions
        /// </summary>
        public int TransactionId { get; set; }
        /// <summary>
        /// Reference from the transactionDetail
        /// </summary>
        public int? TransactionDetalId { get; set; }
        /// <summary>
        /// A reference from the charts of account
        /// </summary>
        public int AccountId { get; set; }
        /// <summary>
        /// Holds reference from tax
        /// </summary>
        public int? TaxId { get; set; }
        /// <summary>
        /// Holds reference to the entity table
        /// </summary>
        public int? EntityId { get; set; }
        /// <summary>
        /// Holds reference to category
        /// </summary>
        public int? CostcenterId { get; set; }
        /// <summary>
        /// Reference to item for ease of reporting
        /// </summary>
        public int? ItemId { get; set; }
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
        /// Reference to the currency for this line item
        /// </summary>
        public int CurrencyId { get; set; }
        /// <summary>
        /// Currency converion rate
        /// </summary>
        public decimal ExcangeRate { get; set; }
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
        public Entity Entity { get; set; }
        public Costcenter Costcenter { get; set; }
        public Item Item { get; set; }
        public Currency Currency { get; set; }
    }
}
