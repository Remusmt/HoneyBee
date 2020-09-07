using HoneyBee.ApplicationCore.Entities.Enums;
using System.Collections.Generic;

namespace HoneyBee.ApplicationCore.Entities
{
    /// <summary>
    /// Done for now
    /// </summary>
    public class ChartofAccount : BaseEntity
    {
        public ChartofAccount()
        {
            ChildChartofAccounts = new HashSet<ChartofAccount>();
        }
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
        /// The rest should have the home currency as currency
        /// </summary>
        public int CurrencyId { get; set; }
        /// <summary>
        /// Should be only of the the same type, and have same currency
        /// </summary>
        public int? ParentAccountId { get; set; }
        /// <summary>
        /// Simply get if has parent its parent height + 1, else 0
        /// </summary>
        public byte Height { get; set; }
        /// <summary>
        /// For expense accounts
        /// </summary>
        public int? TaxId { get; set; }
        /// <summary>
        /// For bank account type
        /// </summary>
        public string BankAccountNumber { get; set; }
        public int? BankBranchId { get; set; }
        public int? BankId { get; set; }
        public bool BlockDirectPosting { get; set; }
        public decimal Balance { get; set; }
        public decimal CurrencyBalance { get; set; }

        public virtual Currency Currency { get; set; }
        public ChartofAccount ParentAccount { get; set; }
        public Tax Tax { get; set; }
        public BankBranch BankBranch { get; set; }
        public Bank Bank { get; set; }

        public ICollection<ChartofAccount> ChildChartofAccounts { get; set; }
    }
}
