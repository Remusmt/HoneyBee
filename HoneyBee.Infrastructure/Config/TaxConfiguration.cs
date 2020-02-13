using HoneyBee.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.Infrastructure.Config
{
    public class TaxConfiguration : IEntityTypeConfiguration<Tax>
    {
        public void Configure(EntityTypeBuilder<Tax> builder)
        {
            builder.HasOne(e => e.TaxAgency)
                .WithMany(e => e.Taxes)
                .HasForeignKey(e => e.TaxAgencyId);
        }
    }

    public class TaxAgencyConfiguration : IEntityTypeConfiguration<TaxAgency>
    {
        public void Configure(EntityTypeBuilder<TaxAgency> builder)
        {
            builder.HasOne(e => e.PurchasesAccount)
                .WithMany()
                .HasForeignKey(e => e.PurchasesAccountId);

            builder.HasOne(e => e.SalesAccount)
                .WithMany()
                .HasForeignKey(e => e.SalesAccountId);
        }
    }
}
