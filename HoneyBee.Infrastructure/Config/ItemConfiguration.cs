using HoneyBee.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.Infrastructure.Config
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasOne(e => e.Category)
                .WithMany()
                .HasForeignKey(e => e.CategoryId);

            builder.HasOne(e => e.ParentItem)
                .WithMany(e => e.ChildItems)
                .HasForeignKey(e => e.ParentItemId);

            builder.HasOne(e => e.UnitsofMeasure)
                .WithMany()
                .HasForeignKey(e => e.UOMId);

            builder.HasOne(e => e.SalesTax)
                .WithMany()
                .HasForeignKey(e => e.SalesTaxId);

            builder.HasOne(e => e.PurchaseTax)
                .WithMany()
                .HasForeignKey(e => e.PurchaseTaxId);
        }
    }
}
