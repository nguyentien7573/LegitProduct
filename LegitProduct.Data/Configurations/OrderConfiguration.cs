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
        public void Configure(EntityTypeBuilder<Order> entity)
        {
            entity.ToTable("Orders");

            entity.HasIndex(e => e.AppUserId)
                    .HasName("IX_Orders_UserId");

            entity.Property(e => e.CreatedUserId)
                .IsRequired()
                .HasMaxLength(25)
                .HasDefaultValueSql("('')");

            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.DateDeleted).HasColumnType("datetime");

            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ShipNameMethod)
                .IsRequired()
                .HasMaxLength(255);

            entity.HasOne(d => d.AppUserAddress)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.AppUserAddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_AppUserAddresses");

            entity.HasOne(d => d.AppUser)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.AppUserId)
                .HasConstraintName("FK_Orders_AppUsers_UserId");

        }
    }
}
