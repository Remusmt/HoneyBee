using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Entities
{
    public class Country
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public string FlagIconUri { get; set; }
    }
}
