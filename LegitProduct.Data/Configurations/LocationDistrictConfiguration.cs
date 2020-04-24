using LegitProduct.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.Data.Configurations
{
    public class LocationDistrictConfiguration : IEntityTypeConfiguration<LocationDistrict>
    {
        public void Configure(EntityTypeBuilder<LocationDistrict> entity)
        {
            entity.ToTable("LocationDistricts");

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

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);

            entity.HasOne(d => d.LocationProvince)
                .WithMany(p => p.LocationDistrict)
                .HasForeignKey(d => d.LocationProvinceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationDistrict_LocationProvinces");
        }
    }
}
