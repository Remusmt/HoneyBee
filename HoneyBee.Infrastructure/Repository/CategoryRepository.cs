using HoneyBee.ApplicationCore.Entities;
using HoneyBee.ApplicationCore.Interfaces;
using HoneyBee.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoneyBee.Infrastructure.Repository
{
    public class CategoryRepository<T> : Repository<T>, ICategoryRepository<T> where T : Category
    {
        public CategoryRepository(HoneyBeeContext honeyBeeContext) : base(honeyBeeContext)
        {
        }

        public async Task<IList<T>> GetTree()
        {
            IReadOnlyList<T> ts = await ListAllAsync();
            List<T> list = ts.ToList();
            list.RemoveAll(e => e.ParentCategory != null);
            return list;
        }

        public bool IfCodeExists(string code, Guid companyId)
        {
            return honeyBeeContext.Set<T>().Any(e => e.Code == code && e.CompanyId == companyId);
        }

        public bool IfDeplicateCode(int Id, string code, Guid companyId)
        {
            return honeyBeeContext.Set<T>().Any(e => e.Code == code && e.CompanyId == companyId && e.Id != Id);
        }

        public bool IfDeplicateDescription(int Id, string description, Guid companyId)
        {
            return honeyBeeContext.Set<T>()
                .Any(e => e.Description == description && e.CompanyId == companyId && e.Id != Id);
        }

        public bool IfDescriptionExists(string description, Guid companyId)
        {
            return honeyBeeContext.Set<T>().Any(e => e.Description == description && e.CompanyId == companyId);
        }
    }
}
