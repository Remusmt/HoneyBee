using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class Bank
    {
        public Guid Id { get; set; }
        public Guid CountryId { get; set; }
        public Country Country { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
    }
}
