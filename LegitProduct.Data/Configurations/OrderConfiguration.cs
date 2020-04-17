using LegitProduct.Data.Entities;
using LegitProduct.Data.ObjectEnums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.OrderDate);

            builder.Property(x => x.Email).IsRequired().IsUnicode(false).HasMaxLength(50);

            builder.Property(x => x.Address).IsRequired().HasMaxLength(255);

            builder.Property(x => x.ShipNameMethod).IsRequired().HasMaxLength(255);

            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(12);

            builder.HasOne(x => x.AppUser).WithMany(x => x.Orders).HasForeignKey(x => x.UserId);

            builder.Property(x => x.Status).HasDefaultValue(OrderStatus.Created);

        }
    }
}
