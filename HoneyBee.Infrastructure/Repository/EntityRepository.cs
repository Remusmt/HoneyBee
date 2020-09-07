using HoneyBee.ApplicationCore.Entities;
using HoneyBee.ApplicationCore.Interfaces;
using HoneyBee.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoneyBee.Infrastructure.Repository
{
    public class EntityRepository<T> : Repository<T>, IEntityRepository<T> where T : Entity
    {
        public EntityRepository(HoneyBeeContext honeyBeeContext) : base(honeyBeeContext)
        {
        }
        public bool IfDuplicateName(int Id, string name, Guid companyId)
        {
            return honeyBeeContext.Set<T>().Any(e => e.Name == name && e.CompanyId == companyId && e.Id != Id);
        }

        public bool IfNameExists(string name, Guid companyId)
        {
            return honeyBeeContext.Set<T>().Any(e => e.Name == name && e.CompanyId == companyId);
        }
    }
}
