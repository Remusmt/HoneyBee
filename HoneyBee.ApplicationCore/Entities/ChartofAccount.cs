using HoneyBee.ApplicationCore.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    /// <summary>
    /// Done for now
    /// </summary>
    public class ChartofAccount : BaseEntity
    {
        public AccountType AccountType { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// Account No for other assets
        /// and notes for everything else
        /// </summary>
        public string Note { get; set; }
        /// <summary>
        /// For Bank, Account Receivable, Accounts Payable
        /// </summary>
        public Guid? CurrencyId { get; set; }
        /// <summary>
        /// Should be only of the the same type, and have same currency
        /// </summary>
        public Guid? ParentAccountId { get; set; }
        /// <summary>
        /// For expense accounts
        /// </summary>
        public Guid? TaxId { get; set; }
        /// <summary>
        /// For bank account type
        /// </summary>
        public string BankAccountNumber { get; set; }
        public Guid? BankBranchId { get; set; }
        public Guid? BankId { get; set; }
        public bool BlockDirectPosting { get; set; }
        public decimal Balance { get; set; }
        public decimal CurrencyBalance { get; set; }

        public virtual Currency Currency { get; set; }
        public ChartofAccount ParentAccount { get; set; }
        public Tax Tax { get; set; }

        public BankBranch BankBranch { get; set; }
        public Bank Bank { get; set; }
    }
}
