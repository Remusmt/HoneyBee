using System.Collections.Generic;

namespace HoneyBee.ApplicationCore.Entities
{
    public class Customer : Entity
    {
        public Customer()
        {
            Projects = new HashSet<Project>();
        }

        public int? SalesRepId { get; set; }
        public int? TaxId { get; set; }

        public SalesRep SalesRep { get; set; }
        public Tax Tax { get; set; }

        public ICollection<Project> Projects { get; set; }

    }
}
