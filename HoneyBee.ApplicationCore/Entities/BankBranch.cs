using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class BankBranch
    {
        [Key]
        public int Id { get; set; }
        public int BankId { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }

        public Bank Bank { get; set; }

    }
}
