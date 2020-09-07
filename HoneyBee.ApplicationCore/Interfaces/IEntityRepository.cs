using HoneyBee.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Interfaces
{
    public interface IEntityRepository<T> : IRepository<T> where T : Entity
    {
        bool IfNameExists(string name, Guid companyId);
        bool IfDuplicateName(int Id, string name, Guid companyId);
    }
}
