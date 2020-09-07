using HoneyBee.ApplicationCore.Entities;
using HoneyBee.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HoneyBee.ApplicationCore.Services
{
    public class GeneralListService<T> where T : BaseEntity
    {
        readonly IRepository<T> repository;
        public GeneralListService(IRepository<T> _repository)
        {
            repository = _repository;
        }

        public async Task<int> Add(T entity)
        {
            repository.Add(entity);
            await repository.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<bool> Update(T entity)
        {
            repository.Update(entity);
            return (await repository.SaveChangesAsync() > 0);
        }

        public async Task<bool> Delete(T entity)
        {
            try
            {
                repository.Delete(entity);
                return (await repository.SaveChangesAsync() > 0);
            }
            catch (Exception)
            {
                throw new Exception("Unable to delete this record because its in use");
            }
        }
    }
}
