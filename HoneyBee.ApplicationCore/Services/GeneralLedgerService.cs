using HoneyBee.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.ApplicationCore.Services
{
    public class GeneralLedgerService
    {
        public void Add(Transaction transaction)
        {
            Type type = typeof(Transaction);
            if (type.Name == "Invoice")
            {

            }
            JournalDetail journalDetail;
        }
    }
}
