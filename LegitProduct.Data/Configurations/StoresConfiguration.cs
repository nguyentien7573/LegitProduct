using LegitProduct.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.Data.Configurations
{
    public class StoresConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> entity)
        {
            entity.ToTable("Stores");

            entity.Property(e => e.Address).HasMaxLength(500);

            entity.Property(e => e.BusinessLicense).HasMaxLength(250);

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

            entity.Property(e => e.Description).HasColumnType("text");

            entity.Property(e => e.ImagePath).HasMaxLength(250);

            entity.Property(e => e.Name).HasMaxLength(250);

            entity.Property(e => e.TaxCode).HasMaxLength(15);

            entity.HasOne(d => d.LocationDistrict)
                .WithMany(p => p.Stores)
                .HasForeignKey(d => d.LocationDistrictId)
                .HasConstraintName("FK_Stores_LocationDistrict");

            entity.HasOne(d => d.LocationProvince)
                .WithMany(p => p.Stores)
                .HasForeignKey(d => d.LocationProvinceId)
                .HasConstraintName("FK_Stores_LocationProvinces");

            entity.HasOne(d => d.LocationVillage)
                .WithMany(p => p.Stores)
                .HasForeignKey(d => d.LocationVillageId)
                .HasConstraintName("FK_Stores_LocationVillage");

            entity.HasOne(d => d.LocationWard)
                .WithMany(p => p.Stores)
                .HasForeignKey(d => d.LocationWardId)
                .HasConstraintName("FK_Stores_LocationWard");
        }
    }
}
