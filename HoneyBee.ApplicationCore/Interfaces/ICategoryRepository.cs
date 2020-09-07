using HoneyBee.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HoneyBee.ApplicationCore.Interfaces
{
    public interface ICategoryRepository<T> : IRepository<T> where T : Category
    {
        bool IfCodeExists(string code, Guid companyId);
        bool IfDescriptionExists(string description, Guid companyId);
        bool IfDuplicateCode(int Id, string code, Guid companyId);
        bool IfDuplicateDescription(int Id, string description, Guid companyId);
        Task<IList<T>> GetTree();
    }
}
