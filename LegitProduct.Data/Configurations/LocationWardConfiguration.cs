using LegitProduct.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.Data.Configurations
{
    public class LocationWardConfiguration : IEntityTypeConfiguration<LocationWard>
    {
        public void Configure(EntityTypeBuilder<LocationWard> entity)
        {
            entity.ToTable("LocationWards");

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

            entity.HasOne(d => d.LocationDistrict)
                .WithMany(p => p.LocationWard)
                .HasForeignKey(d => d.LocationDistrictId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LocationWard_LocationDistrict");
        }
    }
}
