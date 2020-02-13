using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class PaymentDetail : BaseEntity
    {
        public int? PaymentMethodId { get; set; }
        public string AccountNumber { get; set; }
        /// <summary>
        /// To be printed on cheques
        /// </summary>
        public string AccountName { get; set; }
        public int? BankBranchId { get; set; }
        public int? BankId { get; set; }
        public string CreditCardNumber { get; set; }
        public int CreditCardExpiryMonth { get; set; }
        public int CreditCardExpiryYear { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
        public Bank Bank { get; set; }
        public BankBranch BankBranch { get; set; }

    }
}
