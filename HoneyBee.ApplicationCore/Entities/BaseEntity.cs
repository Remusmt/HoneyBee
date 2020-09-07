using HoneyBee.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class BaseEntity : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public Guid CompanyId { get; set; }
        public bool InActive { get; set; }
        public DateTime TimeCreated { get; set; }
    }
}
