using HoneyBee.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.Infrastructure.Config
{
    public class Entityconfiguration : IEntityTypeConfiguration<Entity>
    {
        public void Configure(EntityTypeBuilder<Entity> builder)
        {
            builder.HasOne(e => e.Currency)
                .WithMany()
                .HasForeignKey(e => e.CurrencyId);

            builder.HasOne(e => e.DefaultAddress)
                .WithMany()
                .HasForeignKey(e => e.DefaultAddressId);

            builder.HasOne(e => e.Category)
                .WithMany()
                .HasForeignKey(e => e.CategoryId);

            builder.HasOne(e => e.PaymentTerm)
                .WithMany()
                .HasForeignKey(e => e.PaymentTermId);

            builder.HasOne(e => e.ChartofAccount)
                .WithMany()
                .HasForeignKey(e => e.ChartofAccountId);
        }
    }

    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasOne(e => e.SalesRep)
                .WithMany()
                .HasForeignKey(e => e.SalesRepId);

            builder.HasOne(e => e.Tax)
                .WithMany()
                .HasForeignKey(e => e.TaxId);
        }
    }
}
