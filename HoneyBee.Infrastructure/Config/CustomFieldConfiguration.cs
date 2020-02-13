using HoneyBee.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.Infrastructure.Config
{
    public class CustomFieldConfiguration : IEntityTypeConfiguration<CustomFieldListValue>
    {
        public void Configure(EntityTypeBuilder<CustomFieldListValue> builder)
        {
            builder.HasOne(e => e.CustomField)
                .WithMany(e => e.CustomFieldListValues)
                .HasForeignKey(e => e.CustomFieldId);
        }
    }
}
