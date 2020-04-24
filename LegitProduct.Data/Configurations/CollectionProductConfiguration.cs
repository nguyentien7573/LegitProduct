using LegitProduct.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegitProduct.Data.Configurations
{
    public class CollectionProductConfiguration : IEntityTypeConfiguration<CollectionProduct>
    {
        public void Configure(EntityTypeBuilder<CollectionProduct> entity)
        {
            entity.ToTable("CollectionProducts");

            entity.HasKey(e => new { e.ProductId, e.CollectionId });

            entity.ToTable("Collection_Products");

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

            entity.HasOne(d => d.Collection)
                .WithMany(p => p.CollectionProducts)
                .HasForeignKey(d => d.CollectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Collection_Products_Collections");

            entity.HasOne(d => d.Product)
                .WithMany(p => p.CollectionProducts)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Collection_Products_Products");
        }
    }
}
