using HoneyBee.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace HoneyBee.Infrastructure.Config
{
    public class SaleRepConfiguration : IEntityTypeConfiguration<SalesRep>
    {
        public void Configure(EntityTypeBuilder<SalesRep> builder)
        {
            builder.HasOne(e => e.Entity)
                .WithMany()
                .HasForeignKey(e => e.EntityId);
        }
    }
}
