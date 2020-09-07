using HoneyBee.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Interfaces
{
    public interface ITransactionRepository<T> : IRepository<T> where T : Transaction
    {

    }
}
