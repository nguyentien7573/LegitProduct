using LegitProduct.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.Data.Configurations
{
    public class LogConfiguration : IEntityTypeConfiguration<Log>
    {
        public void Configure(EntityTypeBuilder<Log> entity)
        {
            entity.ToTable("Logs");

            entity.Property(e => e.Action).HasMaxLength(50);

            entity.Property(e => e.AppUserId)
                .HasMaxLength(30)
                .IsUnicode(false);

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

            entity.Property(e => e.TableName)
                .HasMaxLength(30)
                .IsUnicode(false);
        }
    }
}
