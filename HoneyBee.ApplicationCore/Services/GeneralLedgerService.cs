using HoneyBee.ApplicationCore.Entities;
using HoneyBee.ApplicationCore.Entities.Enums;
using HoneyBee.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HoneyBee.ApplicationCore.Services
{
    public class GeneralLedgerService<T> where T : Transaction
    {
        readonly ITransactionRepository<T> repository;
        readonly IEntityRepository<Entity> entityRepository;
        public GeneralLedgerService(ITransactionRepository<T> transactionRepository, IEntityRepository<Entity> entityRepository)
        {
            repository = transactionRepository;
            this.entityRepository = entityRepository;
        }
        public async Task Add(Transaction transaction)
        {
            Invoice invoice = (Invoice)transaction;
            Customer customer = (Customer)await entityRepository.GetByIdAsync(invoice.CustomerId.Value);
            if (customer.ChartofAccountId.HasValue)
                transaction.JournalDetails.Add(new JournalDetail
                {
                    AccountId = customer.ChartofAccountId.Value,
                    Amount = transaction.TotalAmount,
                    CompanyId = transaction.CompanyId,
                    CurrencyAmount = transaction.TotalAmount,
                    CurrencyId = transaction.CurrencyId,
                    Debit = transaction.TotalAmount * transaction.ExcangeRate,
                    ExcangeRate = transaction.ExcangeRate,
                    EntityId = invoice.CustomerId,
                    EnteredDate = transaction.EnteredDate,
                    JournalLine = transaction.JournalDetails.Count + 1,
                    Memo = transaction.ReferenceNumber,
                    TransactionDate = transaction.TransactionDate,
                    TransactionId = transaction.Id
                });

            List<JournalDetail> journalDetails = new List<JournalDetail>();
            foreach (var item in transaction.TransactionDetails)
            {
                journalDetails.Add(new JournalDetail
                {
                    AccountId = 0,
                    Amount = item.SubTotal,
                    CompanyId = item.CompanyId,
                    CostcenterId = item.CostcenterId,
                    CurrencyId = transaction.CurrencyId,
                    CurrencyAmount = item.SubTotal,
                    Credit = item.SubTotal,
                    Debit = item.SubTotal,
                    Deleted = false,
                    EnteredDate = transaction.EnteredDate,
                    ExcangeRate = transaction.ExcangeRate,
                    ItemId = item.ItemId,
                    JournalLine = item.LineNumber,
                    Memo = item.Description,
                    Posted = true,
                    TaxId = item.TaxItemId,
                    TransactionDate = transaction.TransactionDate,
                    TransactionDetalId = item.Id,
                    TimeCreated = DateTime.Now,
                    InActive = false,
                    TransactionId = transaction.Id
                });
            }
        }

        public async Task CreateInvoiceJournal(Invoice invoice, SubscriptionType subscriptionType)
        {
            switch (subscriptionType)
            {
                case SubscriptionType.Service:
                    Customer customer = (Customer)await entityRepository.GetByIdAsync(invoice.CustomerId.Value);
                    if (customer.ChartofAccountId.HasValue)
                        invoice.JournalDetails.Add(new JournalDetail
                        {
                            AccountId = customer.ChartofAccountId.Value,
                            Amount = invoice.TotalAmount,
                            CompanyId = invoice.CompanyId,
                            CurrencyAmount = invoice.TotalAmount,
                            CurrencyId = invoice.CurrencyId,
                            Debit = invoice.TotalAmount * invoice.ExcangeRate,
                            ExcangeRate = invoice.ExcangeRate,
                            EntityId = invoice.CustomerId,
                            EnteredDate = invoice.EnteredDate,
                            JournalLine = invoice.JournalDetails.Count + 1,
                            Memo = invoice.ReferenceNumber,
                            TransactionDate = invoice.TransactionDate,
                            TransactionId = invoice.Id
                        });

                    List<JournalDetail> journalDetails = new List<JournalDetail>();
                    foreach (var item in invoice.TransactionDetails)
                    {
                        journalDetails.Add(new JournalDetail
                        {
                            AccountId = 0,
                            Amount = item.SubTotal,
                            CompanyId = item.CompanyId,
                            CostcenterId = item.CostcenterId,
                            CurrencyId = invoice.CurrencyId,
                            CurrencyAmount = item.SubTotal,
                            Credit = item.SubTotal,
                            Debit = item.SubTotal,
                            Deleted = false,
                            EnteredDate = invoice.EnteredDate,
                            ExcangeRate = invoice.ExcangeRate,
                            ItemId = item.ItemId,
                            JournalLine = item.LineNumber,
                            Memo = item.Description,
                            Posted = true,
                            TaxId = item.TaxItemId,
                            TransactionDate = invoice.TransactionDate,
                            TransactionDetalId = item.Id,
                            TimeCreated = DateTime.Now,
                            InActive = false,
                            TransactionId = invoice.Id
                        });
                    }
                    break;
                case SubscriptionType.GeneralSupplies:
                    break;
                default:
                    break;
            }

        }
    }
}
