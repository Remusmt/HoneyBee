using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class Bank
    {
        public Bank()
        {
            BankBranches = new HashSet<BankBranch>();
        }
        [Key]
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }

        public Country Country { get; set; }
        public ICollection<BankBranch> BankBranches { get; set; }

    }
}
