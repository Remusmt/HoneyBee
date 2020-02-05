using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class BankBranch
    {
        public Guid Id { get; set; }
        public Guid BankId { get; set; }
        public Bank Bank { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
    }
}
