using HoneyBee.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.Infrastructure.Config
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasOne(e => e.Customer)
                .WithMany(e => e.Projects)
                .HasForeignKey(e => e.CustomerId);

            builder.HasOne(e => e.ProjectType)
                .WithMany()
                .HasForeignKey(e => e.ProjectTypeId);
        }
    }
}
