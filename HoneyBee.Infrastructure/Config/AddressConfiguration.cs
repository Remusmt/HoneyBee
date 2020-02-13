using HoneyBee.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.Infrastructure.Config
{
    public class AddressConfiguration : IEntityTypeConfiguration<EntityAddress>
    {
        public void Configure(EntityTypeBuilder<EntityAddress> builder)
        {
            builder.HasOne(e => e.Address)
                .WithMany(e => e.EntityAddresses)
                .HasForeignKey(e => e.AddressId);

            builder.HasOne(e => e.Entity)
                .WithMany(e => e.EntityAddresses)
                .HasForeignKey(e => e.EntityId);
        }
    }
}
