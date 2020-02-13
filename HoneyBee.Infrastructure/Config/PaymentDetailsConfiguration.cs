using HoneyBee.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBee.Infrastructure.Config
{
    public class PaymentDetailsConfiguration : IEntityTypeConfiguration<PaymentDetail>
    {
        public void Configure(EntityTypeBuilder<PaymentDetail> builder)
        {
            builder.HasOne(e => e.PaymentMethod)
                .WithMany()
                .HasForeignKey(e => e.PaymentMethodId);

            builder.HasOne(e => e.Bank)
                .WithMany()
                .HasForeignKey(e => e.BankId);

            builder.HasOne(e => e.BankBranch)
                .WithMany()
                .HasForeignKey(e => e.BankBranchId);
        }
    }
}
