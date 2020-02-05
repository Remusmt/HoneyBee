﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class Entity : BaseEntity
    {
        public Entity()
        {
            Addresses = new HashSet<Address>();
        }
        /// <summary>
        /// Name of the organisation
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// This is the currency by which this org's balance is maintained
        /// </summary>
        public Guid CurrencyId { get; set; }
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// Contact person firstname
        /// </summary>
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string AltPhoneNumber { get; set; }
        public string Email { get; set; }
        public string CCEmail { get; set; }
        public Guid? DefaultAddressId { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? PaymentTermId { get; set; }
        public decimal CreditLimit { get; set; }
        /// <summary>
        /// Used when user wants to track an organisations transactions on the
        /// General ledger separately
        /// </summary>
        public Guid? ChartofAccountId { get; set; }
        /// <summary>
        /// Amount owing or owed. Saved in the org's currency
        /// </summary>
        public decimal Balance { get; set; }
        public decimal CurrencyBalance { get; set; }

        public Currency Currency { get; set; }
        public Address DefaultAddress { get; set; }
        public Category Category { get; set; }
        public PaymentTerm PaymentTerm { get; set; }
        public ChartofAccount ChartofAccount { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}