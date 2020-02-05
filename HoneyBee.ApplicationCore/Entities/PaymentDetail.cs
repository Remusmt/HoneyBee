using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class PaymentDetail
    {
        public Guid? PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string AccountNumber { get; set; }
        /// <summary>
        /// To be printed on cheques
        /// </summary>
        public string AccountName { get; set; }
        public Guid? BankBranchId { get; set; }
        public BankBranch BankBranch { get; set; }
        public Guid? BankId { get; set; }
        public Bank Bank { get; set; }
        public string CreditCardNumber { get; set; }
        public int CreditCardExpiryMonth { get; set; }
        public int CreditCardExpiryYear { get; set; }
    }
}
