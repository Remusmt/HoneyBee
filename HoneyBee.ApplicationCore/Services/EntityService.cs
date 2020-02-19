using HoneyBee.ApplicationCore.Entities;
using HoneyBee.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HoneyBee.ApplicationCore.Services
{
    public class EntityService<T> where T : Entity
    {
        readonly IEntityRepository<T> entityRepository;
        public EntityService(IEntityRepository<T> _entityRepository)
        {
            entityRepository = _entityRepository;

        }

        public async Task<int> Add(T entity)
        {
            if (typeof(T).Name == "TaxAgency")
            {

            }
        }
    }
}
