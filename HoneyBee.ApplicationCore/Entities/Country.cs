using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public string FlagIconUri { get; set; }
    }
}
