using System;

namespace HoneyBee.ApplicationCore.Interfaces
{
    public interface IBaseEntity
    {
        Guid CompanyId { get; set; }
        Guid Id { get; set; }
        bool InActive { get; set; }
    }
}