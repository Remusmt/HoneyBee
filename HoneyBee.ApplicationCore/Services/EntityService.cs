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
            if (string.IsNullOrWhiteSpace(entity.Name))
            {
                throw new Exception("Name requires a value");
            }
            if (entityRepository.IfNameExists(entity.Name, entity.CompanyId))
            {
                throw new Exception("A record with a similar name already exist");
            }

            if (typeof(T).Name == "TaxAgency")
            {
                TaxAgency agency = (TaxAgency)Convert.ChangeType(entity, typeof(TaxAgency));
                if (agency.PurchasesAccount == null && !agency.PurchasesAccountId.HasValue 
                    && agency.SalesAccount == null && !agency.SalesAccountId.HasValue)
                {
                    throw new Exception("Tax agency requires a tax collection account");
                }
            }


            entityRepository.Add(entity);
            await entityRepository.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<bool> Update(T entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Name))
            {
                throw new Exception("Name requires a value");
            }
            if(entityRepository.IfDuplicateName(entity.Id, entity.Name, entity.CompanyId))
            {
                throw new Exception("Updating record with the provided description would create a duplicate record");
            }

            entityRepository.Update(entity);
            await entityRepository.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Delete(T entity)
        {
            try
            {
                entityRepository.Delete(entity);
                await entityRepository.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Unable to delete this record because its in use");
            }
        }
    }
}
