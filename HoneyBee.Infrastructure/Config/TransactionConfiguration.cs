using HoneyBee.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.Infrastructure.Config
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            //var navigation = builder.Metadata.FindNavigation(nameof(Transaction.TransactionDetails));
            //navigation.SetPropertyAccessMode(PropertyAccessMode.Field);

            builder.HasOne(e => e.Currency)
                .WithMany()
                .HasForeignKey(e => e.CurrencyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class JournalDetailConfiguration : IEntityTypeConfiguration<JournalDetail>
    {
        public void Configure(EntityTypeBuilder<JournalDetail> builder)
        {
            builder.HasOne(e => e.ChartofAccount)
                .WithMany()
                .HasForeignKey(e => e.AccountId);

            builder.HasOne(e => e.Transaction)
                .WithMany(e => e.JournalDetails)
                .HasForeignKey(e => e.TransactionId);

            builder.HasOne(e => e.Costcenter)
                .WithMany()
                .HasForeignKey(e => e.CostcenterId);

            builder.HasOne(e => e.TransactionDetail)
                .WithMany(e => e.JournalDetails)
                .HasForeignKey(e => e.TransactionDetalId);

            builder.HasOne(e => e.Entity)
                .WithMany()
                .HasForeignKey(e => e.EntityId);

            builder.HasOne(e => e.Tax)
                .WithMany()
                .HasForeignKey(e => e.TaxId);

            builder.HasOne(e => e.Item)
                .WithMany()
                .HasForeignKey(e => e.ItemId);

            builder.HasOne(e => e.Currency)
                .WithMany()
                .HasForeignKey(e => e.CurrencyId);
        }
    }

    public class TransactionDetailConfiguration : IEntityTypeConfiguration<TransactionDetail>
    {
        public void Configure(EntityTypeBuilder<TransactionDetail> builder)
        {
            builder.HasOne(e => e.Transaction)
                .WithMany(e => e.TransactionDetails)
                .HasForeignKey(e => e.TransactionId);

            builder.HasOne(e => e.Item)
                .WithMany()
                .HasForeignKey(e => e.ItemId);

            builder.HasOne(e => e.UnitsofMeasure)
                .WithMany()
                .HasForeignKey(e => e.UOMId);

            builder.HasOne(e => e.Tax)
                .WithMany()
                .HasForeignKey(e => e.TaxItemId);

            builder.HasOne(e => e.Costcenter)
                .WithMany()
                .HasForeignKey(e => e.CostcenterId);
        }
    }
}
