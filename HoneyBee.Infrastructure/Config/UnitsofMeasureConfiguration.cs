using HoneyBee.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.Infrastructure.Config
{
    public class UnitsofMeasureConfiguration : IEntityTypeConfiguration<UOMConversion>
    {
        public void Configure(EntityTypeBuilder<UOMConversion> builder)
        {
            builder.HasOne(e => e.UOMFrom)
                .WithMany(e => e.UOMConversionsFrom)
                .HasForeignKey(e => e.UoMFromId);

            builder.HasOne(e => e.UOMTo)
                .WithMany(e => e.UOMConversionsTo)
                .HasForeignKey(e => e.UoMToId);
        }
    }
}
