using LegitProduct.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {
            entity.ToTable("Products");
            
            entity.HasIndex(e => e.AppUserId);

            entity.Property(e => e.CreatedUserId)
                .IsRequired()
                .HasMaxLength(25);

            entity.Property(e => e.DateCreated).HasDefaultValueSql("('2020-04-18T20:38:14.7450280+07:00')");

            entity.Property(e => e.DateDeleted).HasColumnType("datetime");

            entity.Property(e => e.DateUpdated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.AppUser)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.AppUserId);
        }
    }
}
