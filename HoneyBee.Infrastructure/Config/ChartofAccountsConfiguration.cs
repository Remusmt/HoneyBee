using HoneyBee.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.Infrastructure.Config
{
    public class ChartofAccountsConfiguration : IEntityTypeConfiguration<ChartofAccount>
    {
        public void Configure(EntityTypeBuilder<ChartofAccount> builder)
        {
            builder.HasOne(e => e.Currency)
                .WithMany()
                .HasForeignKey(e => e.CurrencyId);

            builder.HasOne(e => e.ParentAccount)
                .WithMany(e => e.ChildChartofAccounts)
                .HasForeignKey(e => e.ParentAccountId);

            builder.HasOne(e => e.Tax)
                .WithMany()
                .HasForeignKey(e => e.TaxId);

            builder.HasOne(e => e.Bank)
                .WithMany()
                .HasForeignKey(e => e.BankId);

            builder.HasOne(e => e.BankBranch)
                .WithMany()
                .HasForeignKey(e => e.BankBranchId);
        }
    }
}
