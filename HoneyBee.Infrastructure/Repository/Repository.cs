using HoneyBee.ApplicationCore.Entities;
using HoneyBee.ApplicationCore.Interfaces;
using HoneyBee.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace HoneyBee.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly HoneyBeeContext honeyBeeContext;
        public Repository(HoneyBeeContext _honeyBeeContext)
        {
            //DbContextOptions<HoneyBeeContext> _options = new DbContextOptionsBuilder<HoneyBeeContext>()
            //    .UseSqlServer(connString).Options;
            honeyBeeContext = _honeyBeeContext;
        }

        public void Add(T entity)
        {
            honeyBeeContext.Set<T>().Add(entity);
        }
        public void AddRange(IReadOnlyList<T> entities)
        {
            honeyBeeContext.Set<T>().AddRange(entities);
        }
        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }

        public void Delete(T entity)
        {
            honeyBeeContext.Set<T>().Remove(entity);
        }

        public void DeleteRange(IReadOnlyList<T> entities)
        {
            honeyBeeContext.Set<T>().RemoveRange(entities);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await honeyBeeContext.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await honeyBeeContext.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        public void Update(T entity)
        {
            honeyBeeContext.Entry<T>(honeyBeeContext.Set<T>().Find(entity.Id)).CurrentValues.SetValues(entity);
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(honeyBeeContext.Set<T>().AsQueryable(), spec);
        }

        public int SaveChanges()
        {
            return honeyBeeContext.SaveChanges();
        }

        public int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            return honeyBeeContext.SaveChanges(acceptAllChangesOnSuccess);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await honeyBeeContext.SaveChangesAsync(cancellationToken);
        }

        public async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            return await honeyBeeContext.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return honeyBeeContext.Set<T>().Where(predicate);
        }
    }
}
