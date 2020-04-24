using LegitProduct.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.Data.Configurations
{
    public class AppUserAddressConfiguration : IEntityTypeConfiguration<AppUserAddress>
    {
        public void Configure(EntityTypeBuilder<AppUserAddress> entity)
        {
            entity.ToTable("AppUserAddresses");

            entity.Property(e => e.Address)
                     .IsRequired()
                     .HasMaxLength(500);

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

            entity.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasMaxLength(12)
                .IsFixedLength();

            entity.HasOne(d => d.AppUser)
                .WithMany(p => p.AppUserAddresses)
                .HasForeignKey(d => d.AppUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AppUserAddresses_AppUsers");

            entity.HasOne(d => d.LocationDistrict)
                .WithMany(p => p.AppUserAddresses)
                .HasForeignKey(d => d.LocationDistrictId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AppUserAddresses_LocationDistrict");

            entity.HasOne(d => d.LocationProvince)
                .WithMany(p => p.AppUserAddresses)
                .HasForeignKey(d => d.LocationProvinceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AppUserAddresses_LocationProvinces");

            entity.HasOne(d => d.LocationVillage)
                .WithMany(p => p.AppUserAddresses)
                .HasForeignKey(d => d.LocationVillageId)
                .HasConstraintName("FK_AppUserAddresses_LocationVillage");

            entity.HasOne(d => d.LocationWard)
                .WithMany(p => p.AppUserAddresses)
                .HasForeignKey(d => d.LocationWardId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AppUserAddresses_LocationWard");
        }
    }
}

