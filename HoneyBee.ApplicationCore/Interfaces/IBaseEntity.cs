using System;

namespace HoneyBee.ApplicationCore.Interfaces
{
    public interface IBaseEntity
    {
        Guid CompanyId { get; set; }
        int Id { get; set; }
        bool InActive { get; set; }
    }
}